using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            if (validacionCampos())
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string email = txtMail.Text.Trim();
                string nacimiento = dtpNacimiento.Value.ToString("dd/MM/yyyy");
                string usuario = txtUsuario.Text.Trim();
                string contraseña = txtContraseña.Text.Trim();
                string dni = txtDni.Text.Trim();
                string sexo = cmbSexo.SelectedItem.ToString();
                string grupo = cmbGrupo.SelectedItem.ToString();

                registro.agregarRegistro(nombre, apellido, email, sexo, nacimiento, usuario, contraseña, grupo, dni);
            }
            else
            {
                MessageBox.Show("Tenés que llenar todos los campos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool validacionCampos()
        {
            return
                !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                !string.IsNullOrWhiteSpace(txtApellido.Text) &&
                !string.IsNullOrWhiteSpace(txtMail.Text) &&
                !string.IsNullOrWhiteSpace(txtUsuario.Text) &&
                !string.IsNullOrWhiteSpace(txtContraseña.Text) &&
                !string.IsNullOrWhiteSpace(txtDni.Text) &&
                cmbSexo.SelectedIndex >= 0 &&
                cmbGrupo.SelectedIndex >= 0;
        }


        private void frmRegistro_Load(object sender, EventArgs e)
        {
            registro.dgvUsuariosRegistrados = dgvUsuariosRegistrados;
            cmbSexo.Items.Clear();
            cmbSexo.Items.Add("Femenino");
            cmbSexo.Items.Add("Masculino");
            cmbSexo.Items.Add("Otros");

            string rutaArchivo2 = @"../../Logo/LOGO_IES.ico";
            this.Icon = new Icon(rutaArchivo2);

            cmbGrupo.Items.Clear();
            cmbGrupo.Items.Add("admin");
            cmbGrupo.Items.Add("usuario");



            registro.BuscarRegistro(dgvUsuariosRegistrados);

            dtpNacimiento.CalendarMonthBackground = Color.Black;
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
                if (MessageBox.Show("¿Está seguro de que desea editar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    registro.ModificarRegistro(nombre, apellido, email, sexo, nacimiento, usuario, contraseña, grupo, dni);
                    registro.ModificarUsuario(usuario, contraseña, grupo);
                }

            }
            else if (e.ColumnIndex == 10)
            {
                if (MessageBox.Show("¿Está seguro de que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    registro.EliminarRegistro(dni);
                    registro.EliminarUsuario(usuario);
                    registro.BuscarRegistro(dgvUsuariosRegistrados);
                }
            }
        }
    }
}
