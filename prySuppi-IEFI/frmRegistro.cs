using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
            string grupo = cmbGrupo.SelectedItem.ToString();
            string dni = txtDni.Text;

            registro.agregarRegistro(nombre, apelido, emal, sexo, nacimiento, usuario, contraseña, grupo, dni);
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {
            registro.dgvUsuariosRegistrados = dgvUsuariosRegistrados;
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Otros");

            cmbGrupo.Items.Clear();
            cmbGrupo.Items.Add("admin");
            cmbGrupo.Items.Add("usuario");

            registro.BuscarRegistro(dgvUsuariosRegistrados);
        }

        private void dgvUsuariosRegistrados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string nombre = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[0].Value.ToString();
            string apellido = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[1].Value.ToString();
            string email = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[2].Value.ToString();
            string sexo = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[3].Value.ToString();
            string nacimiento = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[4].Value.ToString();
            string usuario = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[5].Value.ToString();
            string contraseña = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[6].Value.ToString();
            string grupo = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[7].Value.ToString();
            string dni = dgvUsuariosRegistrados.Rows[e.RowIndex].Cells[8].Value.ToString();

            if (e.ColumnIndex == 9)
            {
                registro.ModificarRegistro(nombre,apellido,email,sexo,nacimiento,usuario,contraseña,grupo, dni);

            }
            else if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    registro.EliminarRegistro(dni);
                    registro.BuscarRegistro(dgvUsuariosRegistrados);
                }
            }
        }
    }
}
