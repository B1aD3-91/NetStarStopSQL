using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAPP
{
    public partial class MainForm : Form
    {
        ServicesClass Services = new ServicesClass();
        public MainForm()
        {
            InitializeComponent();
            OffRB.Checked = true;
            //DataGridServices.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Task.Run(() => { DataGridBackgroundRefres(); }); // Run BackgroundThread DataGridRefresher
        }

        private async void AcceptBtn(object sender, EventArgs e) // Radio Button Checked
        {
            AcceptButton.Enabled = false;

            if (OffRB.Checked)
            {
                await Task.Run(() => { Services.StopServicesMethod(ServicesClass.GetSQLServices()); }); //todo need Singleton
                AcceptButton.Enabled = true;
            }
            else
            {
                await Task.Run(() => { Services.StartServicesMethod(ServicesClass.GetSQLServices()); }); //todo need Singleton
                AcceptButton.Enabled = true;
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e) //Drag Window Method
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void CloseBox_Click(object sender, EventArgs e) //Close Button
        {
            this.Close();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e) //Info Button
        {
            MessageBox.Show("При включеном UAC, необходимо подтверждение пользователя на запуск от \"Администратора.\"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal void DataGridBackgroundRefres()
        {
            while (true)
            {
                int position = DataGridServices.FirstDisplayedCell?.RowIndex ?? 0; //Save position scroll\row position

                var s = ServicesClass.GetSQLServices();
                DataGridServices.Invoke(new Action(() =>
                {
                    DataGridServices.Rows.Clear();
                    foreach (var item in s)
                    {
                        DataGridServices.Rows.Add(new string[] { item.DisplayName, item.Status.ToString(), item.StartType.ToString() });
                    }                    
                }));

                DataGridServices.FirstDisplayedScrollingRowIndex = position; //Restore position scroll\row psition
                Thread.Sleep(1000);
            }
        }
    }
}
