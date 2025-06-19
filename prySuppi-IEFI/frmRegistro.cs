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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        clsRegistro registro = new clsRegistro();

        private void gbDatosPersonales_Enter(object sender, EventArgs e)
        {
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Otros");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apelido = txtApellido.Text;
            string emal = txtMail.Text;
            string nacimiento = dtpNacimiento.Value.ToString("dd/MM/yyyy");
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;
            string sexo = cmbSexo.SelectedItem.ToString();

            registro.agregarRegistro(nombre, apelido, emal, sexo, nacimiento, usuario, contraseña);
        }

       
    }
}
