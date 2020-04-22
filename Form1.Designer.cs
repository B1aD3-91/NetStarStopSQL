namespace WindowsFormsAPP
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBoxOnOff = new System.Windows.Forms.GroupBox();
            this.OnRB = new System.Windows.Forms.RadioButton();
            this.OffRB = new System.Windows.Forms.RadioButton();
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBoxOnOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(31, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Accept";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.AcceptBtn);
            // 
            // GroupBoxOnOff
            // 
            this.GroupBoxOnOff.Controls.Add(this.OnRB);
            this.GroupBoxOnOff.Controls.Add(this.OffRB);
            this.GroupBoxOnOff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GroupBoxOnOff.Location = new System.Drawing.Point(12, 27);
            this.GroupBoxOnOff.Name = "GroupBoxOnOff";
            this.GroupBoxOnOff.Size = new System.Drawing.Size(120, 86);
            this.GroupBoxOnOff.TabIndex = 1;
            this.GroupBoxOnOff.TabStop = false;
            this.GroupBoxOnOff.Text = "On or Off";
            // 
            // OnRB
            // 
            this.OnRB.AutoSize = true;
            this.OnRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OnRB.Location = new System.Drawing.Point(7, 53);
            this.OnRB.Name = "OnRB";
            this.OnRB.Size = new System.Drawing.Size(107, 17);
            this.OnRB.TabIndex = 1;
            this.OnRB.TabStop = true;
            this.OnRB.Text = "On SQL Services";
            this.OnRB.UseVisualStyleBackColor = true;
            // 
            // OffRB
            // 
            this.OffRB.AutoSize = true;
            this.OffRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OffRB.Location = new System.Drawing.Point(7, 30);
            this.OffRB.Name = "OffRB";
            this.OffRB.Size = new System.Drawing.Size(107, 17);
            this.OffRB.TabIndex = 0;
            this.OffRB.TabStop = true;
            this.OffRB.Text = "Off SQL Services";
            this.OffRB.UseVisualStyleBackColor = true;
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBox.Image = global::WindowsFormsAPP.Properties.Resources.closeapp;
            this.CloseBox.InitialImage = null;
            this.CloseBox.Location = new System.Drawing.Point(119, 8);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(16, 16);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBox.TabIndex = 2;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(145, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(145, 152);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.GroupBoxOnOff);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.GroupBoxOnOff.ResumeLayout(false);
            this.GroupBoxOnOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GroupBoxOnOff;
        private System.Windows.Forms.RadioButton OnRB;
        private System.Windows.Forms.RadioButton OffRB;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

