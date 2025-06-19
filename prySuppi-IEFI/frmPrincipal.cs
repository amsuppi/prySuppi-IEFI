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
        string gurpo;
        clsUsuario clsUsuario = new clsUsuario();
        public frmPrincipal(string usuario, string gurpo)
        {
            InitializeComponent();
            this.userId = usuario;
            this.gurpo = gurpo;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            if (gurpo == "admin")
            {
                usuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                usuariosToolStripMenuItem.Visible = false;
            }

            tssUser.Text = "User: " + userId;
            tssFecha.Text = "Fecha: " + DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsUsuario.InsertarAuditoria(userId);
        }

        private void auditoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAuditoria frmAuditoria = new frmAuditoria(userId);
            frmAuditoria.Show();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.Show();
        }
    }
}
