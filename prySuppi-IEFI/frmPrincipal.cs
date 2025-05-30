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
    public partial class frmPrincipal : Form
    {
        string user;
        clsUsuario clsUsuario = new clsUsuario();
        public frmPrincipal(string user)
        {
            InitializeComponent();
            this.user = user;
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tssUser.Text = "User: " + user;
            tssFecha.Text = "Fecha: " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void frmPrincipal_FormClosed(object sender, EventArgs e)
        {
            clsUsuario.InsertarAuditoria(user);
        }
    }
}
