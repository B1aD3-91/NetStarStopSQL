using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAPP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            OffRB.Checked = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AcceptBtn(object sender, EventArgs e)
        {
            if (OffRB.Checked)
            {
                ServicesClass.offMethod();
            }
            else
            {
                ServicesClass.onMethod();
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
    }
}
