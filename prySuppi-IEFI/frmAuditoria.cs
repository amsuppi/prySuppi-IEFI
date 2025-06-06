using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        clsBuscar buscar;
        public frmAuditoria(string user)
        {
            InitializeComponent();
            this.userId = user;
            buscar = new clsBuscar(optDetalle, optResumen);
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            optDetalle.Checked = true;
            

            buscar.setearDatosEnDataGrid(userId, dgvAuditoria);
        }

        private void optResumen_CheckedChanged(object sender, EventArgs e)
        {
            buscar.ValidationOpt(userId, dgvAuditoria);
        }
    }
}
