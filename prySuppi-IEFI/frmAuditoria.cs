using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySuppi_IEFI
{
    public partial class frmAuditoria : Form
    {
        string userId;
        public frmAuditoria(string user)
        {
            InitializeComponent();
            this.userId = user;
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            optDetalle.Checked = true;
            Validation();

            string rutaArchivo2 = @"../../Logo/LOGO_IES.ico";
            this.Icon = new Icon(rutaArchivo2);

        }


        private void Validation()
        {
            clsBuscar buscar = new clsBuscar(optDetalle, optResumen);

            buscar.setearDatosEnDataGrid(userId, dgvAuditoria);
        }

        private void optDetalle_CheckedChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void optResumen_CheckedChanged(object sender, EventArgs e)
        {
            Validation();
        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
