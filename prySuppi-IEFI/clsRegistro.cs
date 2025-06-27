using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySuppi_IEFI
{
    internal class clsRegistro
    {

        //Quedaria validar si el usuario existe o no, para no poder crearlo de vuelta y modificaciones de diseño

        clsConexion conexionDatabase = new clsConexion();
        public DataGridView dgvUsuariosRegistrados;

        public void agregarRegistro(string nombre, string apelido, string emal, string sexo, string nacimiento, string usuario, string contraseña, string grupo, string dni)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Registro (Nombre, Apellido, Nacimiento, Sexo, Usuario, Contraseña, Mail, Grupo, Dni) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", nombre);
                        comando.Parameters.AddWithValue("?", apelido);
                        comando.Parameters.AddWithValue("?", nacimiento);
                        comando.Parameters.AddWithValue("?", sexo);
                        comando.Parameters.AddWithValue("?", usuario);
                        comando.Parameters.AddWithValue("?", contraseña);
                        comando.Parameters.AddWithValue("?", emal);
                        comando.Parameters.AddWithValue("?", grupo);
                        comando.Parameters.AddWithValue("?", dni);

                        int filas = comando.ExecuteNonQuery();
                        agregarUsuario(usuario, contraseña, grupo);
                        BuscarRegistro(dgvUsuariosRegistrados);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }

        private void agregarUsuario(string usuario, string contraseña, string grupo)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Usuarios (Usuario, Contraseña, Grupo) VALUES (?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", usuario);
                        comando.Parameters.AddWithValue("?", contraseña);
                        comando.Parameters.AddWithValue("?", grupo);

                        int filas = comando.ExecuteNonQuery();
                        MessageBox.Show("Persona agregado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }

        public void ModificarRegistro(string nombre, string apellido, string email, string sexo, string nacimiento, string usuario, string contraseña, string grupo, string dni)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "UPDATE Registro SET Nombre = ?, Apellido = ?, Nacimiento = ?, Sexo = ?, Usuario = ?, Contraseña = ?, Mail = ?, Grupo = ? WHERE Dni = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", nombre);
                        comando.Parameters.AddWithValue("?", apellido);
                        comando.Parameters.AddWithValue("?", nacimiento);
                        comando.Parameters.AddWithValue("?", sexo);
                        comando.Parameters.AddWithValue("?", usuario);
                        comando.Parameters.AddWithValue("?", contraseña);
                        comando.Parameters.AddWithValue("?", email);
                        comando.Parameters.AddWithValue("?", grupo);
                        comando.Parameters.AddWithValue("?", dni);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro modificado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar registro: " + ex.Message);
                }
            }
        }

        public void ModificarUsuario(string usuario, string contraseña, string grupo)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "UPDATE Registro SET Usuario = ?, Contraseña = ?, Grupo = ? WHERE Usuario = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", usuario);
                        comando.Parameters.AddWithValue("?", contraseña);
                        comando.Parameters.AddWithValue("?", grupo);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar registro: " + ex.Message);
                }
            }
        }

        public void EliminarUsuario(string usuario)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "DELETE FROM Usuarios WHERE Usuario = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", usuario);

                        int filas = comando.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar registro: " + ex.Message);
                }
            }
        }
        public void EliminarRegistro(string dni)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "DELETE FROM Registro WHERE Dni = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", dni);

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                            MessageBox.Show("Registro eliminado correctamente");
                        else
                            MessageBox.Show("No se encontró el registro con el DNI especificado");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar registro: " + ex.Message);
                }
            }
        }

        public OleDbDataReader ObtenerRegistrosReader()
        {
            OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString);

            try
            {
                conexion.Open();

                string query = "SELECT Nombre, Apellido, Mail, Sexo, Nacimiento, Usuario, Contraseña, Grupo, Dni FROM Registro";

                OleDbCommand comando = new OleDbCommand(query, conexion);

                return comando.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener registros: " + ex.Message);
                return null;
            }
        }


        public void BuscarRegistro(DataGridView dgvUsuariosRegistrados)
        {
            dgvUsuariosRegistrados.AllowUserToAddRows = false;

            dgvUsuariosRegistrados.Rows.Clear();
            dgvUsuariosRegistrados.Columns.Clear();

            // Agregar columnas de datos
            dgvUsuariosRegistrados.Columns.Add("Nombre", "Nombre");
            dgvUsuariosRegistrados.Columns.Add("Apellido", "Apellido");
            dgvUsuariosRegistrados.Columns.Add("Email", "Email");
            dgvUsuariosRegistrados.Columns.Add("Sexo", "Sexo");
            dgvUsuariosRegistrados.Columns.Add("Nacimiento", "Nacimiento");
            dgvUsuariosRegistrados.Columns.Add("Usuario", "Usuario");
            dgvUsuariosRegistrados.Columns.Add("Contraseña", "Contraseña");
            dgvUsuariosRegistrados.Columns.Add("Grupo", "Grupo");
            dgvUsuariosRegistrados.Columns.Add("DNI", "Dni");

            // Agregar columna de botón Editar
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
            btnEditar.Name = "btnEditar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "Editar";
            btnEditar.UseColumnTextForButtonValue = true;
            dgvUsuariosRegistrados.Columns.Add(btnEditar);

            // Agregar columna de botón Eliminar
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "btnEliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            dgvUsuariosRegistrados.Columns.Add(btnEliminar);

            

                using (OleDbDataReader reader = ObtenerRegistrosReader())
            {
                if (reader != null)
                {
                    while (reader.Read())
                    {
                        dgvUsuariosRegistrados.Rows.Add(
                            reader["Nombre"],
                            reader["Apellido"],
                            reader["Mail"],
                            reader["Sexo"],
                            reader["Nacimiento"],
                            reader["Usuario"],
                            reader["Contraseña"],
                            reader["Grupo"],
                            reader["DNI"]
                        );
                    }
                }
            }
        }
    }
}
