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
    public partial class frmLogin : Form
    {
        clsUsuario clsUsuario = new clsUsuario();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            lblPass.Text = clsUsuario.EstadoDeConeccion();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsUsuario.ValidarUsuario(txtUser.Text, txtPass.Text))
            {
                frmPrincipal frmPrincipal = new frmPrincipal(txtUser.Text);
                frmPrincipal.Show();

                clsUsuario.ConteoDeTiempo();
                lblPass.Text = clsUsuario.EstadoDeConeccion();
            } else
            {
                MessageBox.Show("Error: Alguno de los datos son incorrectos");
            }
            
        }

        private void frmLogin_FormClosedFormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
