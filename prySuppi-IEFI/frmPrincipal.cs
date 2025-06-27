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

        frmAuditoria frmAuditoria;
        frmRegistro frmRegistro;
        frmLogin frmLogin;
        Stopwatch cronometro;
        public frmPrincipal(string usuario, string gurpo, frmLogin frmLogin)
        {
            InitializeComponent();
            this.userId = usuario;
            this.gurpo = gurpo;
            cronometro = new Stopwatch();
            this.frmLogin = frmLogin;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            cronometro.Start();
            string rutaArchivo = @"../../Logo/LOGO_IES.png";
            string rutaArchivo2 = @"../../Logo/LOGO_IES.ico";
            pbLogo.Image = Image.FromFile(rutaArchivo);
            this.Icon = new Icon(rutaArchivo2);


            pbLogo.Left = (this.ClientSize.Width - pbLogo.Width) / 2;
            pbLogo.Top = (this.ClientSize.Height - pbLogo.Height) / 2;


            ToolStripStatusLabel espacio = new ToolStripStatusLabel();
            espacio.Spring = true;
            sstItems.Items.Insert(1, espacio);


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
            frmAuditoria = new frmAuditoria(userId);
            frmAuditoria.Show();
        }

        private void administracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistro = new frmRegistro();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin.Show();

            frmRegistro?.Close();
            frmAuditoria?.Close();
            this.Close();

            this.Hide();


        }
    }
}
