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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // optDetalle
            // 
            this.optDetalle.AutoSize = true;
            this.optDetalle.Location = new System.Drawing.Point(13, 13);
            this.optDetalle.Name = "optDetalle";
            this.optDetalle.Size = new System.Drawing.Size(58, 17);
            this.optDetalle.TabIndex = 0;
            this.optDetalle.TabStop = true;
            this.optDetalle.Text = "Detalle";
            this.optDetalle.UseVisualStyleBackColor = true;
            // 
            // optResumen
            // 
            this.optResumen.AutoSize = true;
            this.optResumen.Location = new System.Drawing.Point(116, 13);
            this.optResumen.Name = "optResumen";
            this.optResumen.Size = new System.Drawing.Size(70, 17);
            this.optResumen.TabIndex = 1;
            this.optResumen.TabStop = true;
            this.optResumen.Text = "Resumen";
            this.optResumen.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(375, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 204);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.optResumen);
            this.Controls.Add(this.optDetalle);
            this.Name = "frmAuditoria";
            this.Text = "Auditoria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton optDetalle;
        private System.Windows.Forms.RadioButton optResumen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}