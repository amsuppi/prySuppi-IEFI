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
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTareas,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(471, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTareas
            // 
            this.tsmTareas.Name = "tsmTareas";
            this.tsmTareas.Size = new System.Drawing.Size(64, 24);
            this.tsmTareas.Text = "Tareas";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administracionToolStripMenuItem.Text = "Administracion";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.sstItems.Location = new System.Drawing.Point(0, 180);
            this.sstItems.Name = "sstItems";
            this.sstItems.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.sstItems.Size = new System.Drawing.Size(471, 26);
            this.sstItems.TabIndex = 1;
            this.sstItems.Text = "statusStrip1";
            // 
            // tssUser
            // 
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(41, 20);
            this.tssUser.Text = "User:";
            this.tssUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tssFecha
            // 
            this.tssFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssFecha.Name = "tssFecha";
            this.tssFecha.Size = new System.Drawing.Size(50, 20);
            this.tssFecha.Text = "Fecha:";
            this.tssFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(313, 533);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 16);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblFechaInfo
            // 
            this.lblFechaInfo.AutoSize = true;
            this.lblFechaInfo.Location = new System.Drawing.Point(363, 533);
            this.lblFechaInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaInfo.Name = "lblFechaInfo";
            this.lblFechaInfo.Size = new System.Drawing.Size(80, 16);
            this.lblFechaInfo.TabIndex = 3;
            this.lblFechaInfo.Text = "lblFechaInfo";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(46, 533);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(44, 16);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "label1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 206);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblFechaInfo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.sstItems);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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