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
    public partial class frmPrincipal : Form
    {
        string userId;
        string gurpo;
        clsUsuario clsUsuario = new clsUsuario();
        Stopwatch cronometro;
        public frmPrincipal(string usuario, string gurpo)
        {
            InitializeComponent();
            this.userId = usuario;
            this.gurpo = gurpo;
            cronometro = new Stopwatch();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cronometro.Start();

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

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            cronometro.Stop(); // ⏹ Detiene cuando se cierra

            // Calcula tiempo en segundos (o lo que necesites)
            int tiempoTranscurrido = (int)cronometro.Elapsed.Seconds;

            // Guarda en base de datos usando tu clase
            clsUsuario usuario = new clsUsuario();
            usuario.InsertarAuditoria(userId, tiempoTranscurrido);
        }
    }
}
