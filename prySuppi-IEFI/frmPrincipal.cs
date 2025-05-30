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
        string userId;
        clsUsuario clsUsuario = new clsUsuario();
        public frmPrincipal(string user)
        {
            InitializeComponent();
            this.userId = user;
            
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tssUser.Text = "User: " + userId;
            tssFecha.Text = "Fecha: " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsUsuario.InsertarAuditoria(userId);
        }
    }
}
