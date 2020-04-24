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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.GroupBoxOnOff = new System.Windows.Forms.GroupBox();
            this.OnRB = new System.Windows.Forms.RadioButton();
            this.OffRB = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridServices = new System.Windows.Forms.DataGridView();
            this.ServiceNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerSender = new System.Windows.Forms.Timer(this.components);
            this.CloseBox = new System.Windows.Forms.PictureBox();
            this.GroupBoxOnOff.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptButton
            // 
            this.AcceptButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AcceptButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.AcceptButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AcceptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AcceptButton.Location = new System.Drawing.Point(31, 120);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 0;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = false;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptBtn);
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
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(40, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(40, 25);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(33, 19);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // DataGridServices
            // 
            this.DataGridServices.AllowUserToAddRows = false;
            this.DataGridServices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            this.DataGridServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridServices.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.DataGridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceNameColumn,
            this.StatusColumn,
            this.StartTypeColumn});
            this.DataGridServices.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.DataGridServices.Location = new System.Drawing.Point(153, 27);
            this.DataGridServices.Name = "DataGridServices";
            this.DataGridServices.ReadOnly = true;
            this.DataGridServices.RowHeadersVisible = false;
            this.DataGridServices.Size = new System.Drawing.Size(543, 191);
            this.DataGridServices.TabIndex = 4;
            // 
            // ServiceNameColumn
            // 
            this.ServiceNameColumn.Frozen = true;
            this.ServiceNameColumn.HeaderText = "ServiceName";
            this.ServiceNameColumn.MaxInputLength = 500;
            this.ServiceNameColumn.Name = "ServiceNameColumn";
            this.ServiceNameColumn.ReadOnly = true;
            this.ServiceNameColumn.Width = 350;
            // 
            // StatusColumn
            // 
            this.StatusColumn.Frozen = true;
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.MaxInputLength = 100;
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.ReadOnly = true;
            // 
            // StartTypeColumn
            // 
            this.StartTypeColumn.Frozen = true;
            this.StartTypeColumn.HeaderText = "StartType";
            this.StartTypeColumn.MaxInputLength = 100;
            this.StartTypeColumn.Name = "StartTypeColumn";
            this.StartTypeColumn.ReadOnly = true;
            // 
            // TimerSender
            // 
            this.TimerSender.Interval = 1000;
            // 
            // CloseBox
            // 
            this.CloseBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CloseBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBox.Image = global::WindowsFormsAPP.Properties.Resources.closeapp;
            this.CloseBox.InitialImage = null;
            this.CloseBox.Location = new System.Drawing.Point(679, 7);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.Size = new System.Drawing.Size(16, 16);
            this.CloseBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBox.TabIndex = 2;
            this.CloseBox.TabStop = false;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(711, 230);
            this.Controls.Add(this.DataGridServices);
            this.Controls.Add(this.CloseBox);
            this.Controls.Add(this.GroupBoxOnOff);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartSopperSQL";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.GroupBoxOnOff.ResumeLayout(false);
            this.GroupBoxOnOff.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.GroupBox GroupBoxOnOff;
        private System.Windows.Forms.RadioButton OnRB;
        private System.Windows.Forms.RadioButton OffRB;
        private System.Windows.Forms.PictureBox CloseBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.DataGridView DataGridServices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTypeColumn;
        private System.Windows.Forms.Timer TimerSender;
    }
}

