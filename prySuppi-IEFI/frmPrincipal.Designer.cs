namespace prySuppi_IEFI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sstItems = new System.Windows.Forms.StatusStrip();
            this.tssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFechaInfo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.sstItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTareas,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(530, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTareas
            // 
            this.tsmTareas.Name = "tsmTareas";
            this.tsmTareas.Size = new System.Drawing.Size(76, 29);
            this.tsmTareas.Text = "Tareas";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(147, 29);
            this.administracionToolStripMenuItem.Text = "Administracion";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // sstItems
            // 
            this.sstItems.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sstItems.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sstItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUser,
            this.tssFecha});
            this.sstItems.Location = new System.Drawing.Point(0, 226);
            this.sstItems.Name = "sstItems";
            this.sstItems.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.sstItems.Size = new System.Drawing.Size(530, 32);
            this.sstItems.TabIndex = 1;
            this.sstItems.Text = "statusStrip1";
            // 
            // tssUser
            // 
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(51, 25);
            this.tssUser.Text = "User:";
            this.tssUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssFecha
            // 
            this.tssFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssFecha.Name = "tssFecha";
            this.tssFecha.Size = new System.Drawing.Size(61, 25);
            this.tssFecha.Text = "Fecha:";
            this.tssFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(352, 666);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(58, 20);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFechaInfo
            // 
            this.lblFechaInfo.AutoSize = true;
            this.lblFechaInfo.Location = new System.Drawing.Point(408, 666);
            this.lblFechaInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInfo.Name = "lblFechaInfo";
            this.lblFechaInfo.Size = new System.Drawing.Size(97, 20);
            this.lblFechaInfo.TabIndex = 3;
            this.lblFechaInfo.Text = "lblFechaInfo";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(52, 666);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(51, 20);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "label1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(530, 258);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblFechaInfo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.sstItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sstItems.ResumeLayout(false);
            this.sstItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmTareas;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditoriaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip sstItems;
        private System.Windows.Forms.ToolStripStatusLabel tssUser;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFechaInfo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripStatusLabel tssFecha;
    }
}