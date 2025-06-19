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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // optDetalle
            // 
            this.optDetalle.AutoSize = true;
            this.optDetalle.Location = new System.Drawing.Point(18, 16);
            this.optDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.optDetalle.Name = "optDetalle";
            this.optDetalle.Size = new System.Drawing.Size(71, 20);
            this.optDetalle.TabIndex = 0;
            this.optDetalle.TabStop = true;
            this.optDetalle.Text = "Detalle";
            this.optDetalle.UseVisualStyleBackColor = true;
            this.optDetalle.CheckedChanged += new System.EventHandler(this.optDetalle_CheckedChanged);
            // 
            // optResumen
            // 
            this.optResumen.AutoSize = true;
            this.optResumen.Location = new System.Drawing.Point(155, 16);
            this.optResumen.Margin = new System.Windows.Forms.Padding(4);
            this.optResumen.Name = "optResumen";
            this.optResumen.Size = new System.Drawing.Size(86, 20);
            this.optResumen.TabIndex = 1;
            this.optResumen.TabStop = true;
            this.optResumen.Text = "Resumen";
            this.optResumen.UseVisualStyleBackColor = true;
            this.optResumen.CheckedChanged += new System.EventHandler(this.optResumen_CheckedChanged);
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(18, 46);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 62;
            this.dgvAuditoria.Size = new System.Drawing.Size(500, 185);
            this.dgvAuditoria.TabIndex = 2;
            this.dgvAuditoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuditoria_CellContentClick);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(533, 251);
            this.Controls.Add(this.dgvAuditoria);
            this.Controls.Add(this.optResumen);
            this.Controls.Add(this.optDetalle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAuditoria";
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
    }
}