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

            if (userId == "admin")
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
