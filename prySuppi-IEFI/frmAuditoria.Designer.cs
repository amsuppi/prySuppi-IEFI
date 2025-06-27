namespace prySuppi_IEFI
{
    partial class frmAuditoria
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
            this.optDetalle = new System.Windows.Forms.RadioButton();
            this.optResumen = new System.Windows.Forms.RadioButton();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.lblLista = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // optDetalle
            // 
            this.optDetalle.AutoSize = true;
            this.optDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDetalle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.optDetalle.Location = new System.Drawing.Point(854, 22);
            this.optDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.optDetalle.Name = "optDetalle";
            this.optDetalle.Size = new System.Drawing.Size(76, 24);
            this.optDetalle.TabIndex = 0;
            this.optDetalle.TabStop = true;
            this.optDetalle.Text = "Todos";
            this.optDetalle.UseVisualStyleBackColor = true;
            this.optDetalle.CheckedChanged += new System.EventHandler(this.optDetalle_CheckedChanged);
            // 
            // optResumen
            // 
            this.optResumen.AutoSize = true;
            this.optResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optResumen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.optResumen.Location = new System.Drawing.Point(960, 22);
            this.optResumen.Margin = new System.Windows.Forms.Padding(4);
            this.optResumen.Name = "optResumen";
            this.optResumen.Size = new System.Drawing.Size(66, 24);
            this.optResumen.TabIndex = 1;
            this.optResumen.TabStop = true;
            this.optResumen.Text = "Mios";
            this.optResumen.UseVisualStyleBackColor = true;
            this.optResumen.CheckedChanged += new System.EventHandler(this.optResumen_CheckedChanged);
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuditoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAuditoria.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvAuditoria.Location = new System.Drawing.Point(18, 70);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 62;
            this.dgvAuditoria.Size = new System.Drawing.Size(1056, 378);
            this.dgvAuditoria.TabIndex = 2;
            this.dgvAuditoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellContentClick);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLista.Location = new System.Drawing.Point(13, 22);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(177, 25);
            this.lblLista.TabIndex = 3;
            this.lblLista.Text = "Lista de auditoria";
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1087, 461);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.dgvAuditoria);
            this.Controls.Add(this.optResumen);
            this.Controls.Add(this.optDetalle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAuditoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auditoria";
            this.Load += new System.EventHandler(this.frmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optDetalle;
        private System.Windows.Forms.RadioButton optResumen;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Label lblLista;
    }
}