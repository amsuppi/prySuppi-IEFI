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
        public frmAuditoria(string user)
        {
            InitializeComponent();
            this.userId = user;
        }

        private void frmAuditoria_Load(object sender, EventArgs e)
        {
            optDetalle.Checked = true;
            clsBuscar buscar = new clsBuscar(optDetalle, optResumen);

            buscar.setearDatosEnDataGrid(userId, dgvAuditoria);
        }
    }
}
