using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAPP
{
    public partial class MainForm : Form
    {
        ServicesClass Services = new ServicesClass();
        private static object locker = new object();
        public MainForm()
        {
            InitializeComponent();
            OffRB.Checked = true;
            TimerSender.Start();
            DataGridServices.Enabled = false;
            Task.Run(() => { TimerWaiter(); });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async void AcceptBtn(object sender, EventArgs e)
        {
            AcceptButton.Enabled = false;

            if (OffRB.Checked)
            {
                await Task.Run(() => { Services.StopServicesMethod(ServicesClass.GetSQLServices()); });
                AcceptButton.Enabled = true;
            }
            else
            {
                await Task.Run(() => { Services.StartServicesMethod(ServicesClass.GetSQLServices()); });
                AcceptButton.Enabled = true;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void CloseBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("При включеном UAC, необходимо подтверждение пользователя на запуск от \"Администратора.\"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal void TimerWaiter()
        {
            while (true)
            {
                var s = ServicesClass.GetSQLServices();
                DataGridServices.Invoke(new Action(() =>
                {
                    DataGridServices.Rows.Clear();
                    foreach (var item in s)
                    {
                        DataGridServices.Rows.Add(new string[] { item.DisplayName, item.Status.ToString(), item.StartType.ToString() });
                    }
                }));
                Thread.Sleep(1000);
            }
        }
    }
}
