namespace prySuppi_IEFI
{
    partial class frmRegistro
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
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dgvUsuariosRegistrados = new System.Windows.Forms.DataGridView();
            this.lbUsuarioRegstrados = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.gbDatosPersonales.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRegistrados)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.lblDni);
            this.gbDatosPersonales.Controls.Add(this.txtDni);
            this.gbDatosPersonales.Controls.Add(this.txtApellido);
            this.gbDatosPersonales.Controls.Add(this.lblMail);
            this.gbDatosPersonales.Controls.Add(this.lbApellido);
            this.gbDatosPersonales.Controls.Add(this.lblNacimiento);
            this.gbDatosPersonales.Controls.Add(this.lblSexo);
            this.gbDatosPersonales.Controls.Add(this.lblNombre);
            this.gbDatosPersonales.Controls.Add(this.cmbSexo);
            this.gbDatosPersonales.Controls.Add(this.dtpNacimiento);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.txtMail);
            this.gbDatosPersonales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatosPersonales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDatosPersonales.Location = new System.Drawing.Point(17, 93);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(1195, 231);
            this.gbDatosPersonales.TabIndex = 0;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personale";
            this.gbDatosPersonales.Enter += new System.EventHandler(this.gbDatosPersonales_Enter);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(638, 163);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(35, 20);
            this.lblDni.TabIndex = 16;
            this.lblDni.Text = "Dni";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDni.Location = new System.Drawing.Point(641, 186);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(534, 27);
            this.txtDni.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtApellido.Location = new System.Drawing.Point(641, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(534, 27);
            this.txtApellido.TabIndex = 14;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(20, 163);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(40, 20);
            this.lblMail.TabIndex = 13;
            this.lblMail.Text = "Mail";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(638, 23);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(68, 20);
            this.lbApellido.TabIndex = 12;
            this.lbApellido.Text = "Apellido";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(20, 85);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(164, 20);
            this.lblNacimiento.TabIndex = 11;
            this.lblNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(638, 85);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(46, 20);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.cmbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSexo.ForeColor = System.Drawing.Color.White;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(641, 113);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(534, 28);
            this.cmbSexo.TabIndex = 6;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dtpNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dtpNacimiento.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dtpNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dtpNacimiento.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dtpNacimiento.Location = new System.Drawing.Point(23, 114);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(534, 27);
            this.dtpNacimiento.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.Location = new System.Drawing.Point(23, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(534, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMail.Location = new System.Drawing.Point(23, 186);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(534, 27);
            this.txtMail.TabIndex = 1;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.txtContraseña);
            this.gbUsuario.Controls.Add(this.btnAgregar);
            this.gbUsuario.Controls.Add(this.lblUsuario);
            this.gbUsuario.Controls.Add(this.lblContraseña);
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuario.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbUsuario.Location = new System.Drawing.Point(17, 345);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(1195, 163);
            this.gbUsuario.TabIndex = 1;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario";
            this.gbUsuario.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtContraseña.Location = new System.Drawing.Point(641, 56);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(534, 27);
            this.txtContraseña.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(180)))), ((int)(((byte)(248)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAgregar.Location = new System.Drawing.Point(961, 102);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(214, 43);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(20, 30);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(67, 20);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(638, 30);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(95, 20);
            this.lblContraseña.TabIndex = 8;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUsuario.Location = new System.Drawing.Point(23, 56);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(534, 27);
            this.txtUsuario.TabIndex = 4;
            // 
            // dgvUsuariosRegistrados
            // 
            this.dgvUsuariosRegistrados.AllowUserToResizeColumns = false;
            this.dgvUsuariosRegistrados.AllowUserToResizeRows = false;
            this.dgvUsuariosRegistrados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuariosRegistrados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuariosRegistrados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dgvUsuariosRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosRegistrados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dgvUsuariosRegistrados.Location = new System.Drawing.Point(12, 561);
            this.dgvUsuariosRegistrados.Name = "dgvUsuariosRegistrados";
            this.dgvUsuariosRegistrados.RowHeadersWidth = 51;
            this.dgvUsuariosRegistrados.RowTemplate.Height = 24;
            this.dgvUsuariosRegistrados.Size = new System.Drawing.Size(1195, 231);
            this.dgvUsuariosRegistrados.TabIndex = 2;
            this.dgvUsuariosRegistrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosRegistrados_CellContentClick);
            // 
            // lbUsuarioRegstrados
            // 
            this.lbUsuarioRegstrados.AutoSize = true;
            this.lbUsuarioRegstrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarioRegstrados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUsuarioRegstrados.Location = new System.Drawing.Point(12, 527);
            this.lbUsuarioRegstrados.Name = "lbUsuarioRegstrados";
            this.lbUsuarioRegstrados.Size = new System.Drawing.Size(217, 25);
            this.lbUsuarioRegstrados.TabIndex = 3;
            this.lbUsuarioRegstrados.Text = "Usuarios Registrados";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.cmbGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbGrupo.ForeColor = System.Drawing.Color.White;
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(17, 42);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(534, 24);
            this.cmbGrupo.TabIndex = 19;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGrupo.Location = new System.Drawing.Point(14, 19);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(127, 16);
            this.lblGrupo.TabIndex = 20;
            this.lblGrupo.Text = "Selecciona el grupo";
            this.lblGrupo.Click += new System.EventHandler(this.lblGrupo_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1219, 804);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.lbUsuarioRegstrados);
            this.Controls.Add(this.dgvUsuariosRegistrados);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.gbDatosPersonales);
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resgistro";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosRegistrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView dgvUsuariosRegistrados;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbUsuarioRegstrados;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label lblGrupo;
    }
}