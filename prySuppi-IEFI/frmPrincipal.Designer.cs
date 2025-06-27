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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.sstItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTareas,
            this.administracionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1059, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmTareas
            // 
            this.tsmTareas.ForeColor = System.Drawing.Color.Black;
            this.tsmTareas.Name = "tsmTareas";
            this.tsmTareas.Size = new System.Drawing.Size(71, 27);
            this.tsmTareas.Text = "Tareas";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.auditoriaToolStripMenuItem});
            this.administracionToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(138, 27);
            this.administracionToolStripMenuItem.Text = "Administracion";
            this.administracionToolStripMenuItem.Click += new System.EventHandler(this.administracionToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // auditoriaToolStripMenuItem
            // 
            this.auditoriaToolStripMenuItem.Name = "auditoriaToolStripMenuItem";
            this.auditoriaToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.auditoriaToolStripMenuItem.Text = "Auditoria";
            this.auditoriaToolStripMenuItem.Click += new System.EventHandler(this.auditoriaToolStripMenuItem_Click);
            // 
            // sstItems
            // 
            this.sstItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.sstItems.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sstItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssUser,
            this.tssFecha});
            this.sstItems.Location = new System.Drawing.Point(0, 419);
            this.sstItems.Name = "sstItems";
            this.sstItems.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.sstItems.Size = new System.Drawing.Size(1059, 29);
            this.sstItems.TabIndex = 1;
            this.sstItems.Text = "statusStrip1";
            // 
            // tssUser
            // 
            this.tssUser.ForeColor = System.Drawing.Color.White;
            this.tssUser.Name = "tssUser";
            this.tssUser.Size = new System.Drawing.Size(41, 23);
            this.tssUser.Text = "User:";
            this.tssUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tssUser.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // tssFecha
            // 
            this.tssFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tssFecha.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssFecha.ForeColor = System.Drawing.Color.White;
            this.tssFecha.LinkColor = System.Drawing.Color.White;
            this.tssFecha.Name = "tssFecha";
            this.tssFecha.Size = new System.Drawing.Size(58, 23);
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
            // pbLogo
            // 
            this.pbLogo.InitialImage = global::prySuppi_IEFI.Properties.Resources.LOGO_IES;
            this.pbLogo.Location = new System.Drawing.Point(413, 123);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(252, 170);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(898, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1059, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblFechaInfo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.sstItems);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sstItems.ResumeLayout(false);
            this.sstItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button button1;
    }
}