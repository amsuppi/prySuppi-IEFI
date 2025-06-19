using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySuppi_IEFI
{
    internal class clsRegistro
    {

        clsConexion conexionDatabase = new clsConexion();

        public void agregarRegistro(string nombre, string apelido, string emal, string sexo, string nacimiento, string usuario, string contraseña)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Registro (Nombre, Apellido, Nacimiento, Sexo, Usuario, Contraseña, Mail) VALUES (?, ?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", nombre);
                        comando.Parameters.AddWithValue("?", apelido);
                        comando.Parameters.AddWithValue("?", nacimiento);
                        comando.Parameters.AddWithValue("?", sexo);
                        comando.Parameters.AddWithValue("?", usuario);
                        comando.Parameters.AddWithValue("?", contraseña);
                        comando.Parameters.AddWithValue("?", emal);

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

        public void modificarRegistro(int Codigo, string Nombre, string Precio, int Stock, string Descripcion, string Categorias)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "UPDATE Productos SET Nombre = ?, Descripcion = ?, Precio = ?, Stock = ?, Categorias = ? WHERE Codigo = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", Nombre);
                        comando.Parameters.AddWithValue("?", Descripcion);
                        comando.Parameters.AddWithValue("?", Precio);
                        comando.Parameters.AddWithValue("?", Stock);
                        comando.Parameters.AddWithValue("?", Categorias);
                        comando.Parameters.AddWithValue("?", Codigo); // El Código va al final porque está en el WHERE

                        int filas = comando.ExecuteNonQuery();
                        MessageBox.Show("Producto modificado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar o modificar en la base de datos: " + ex.Message);
                }
            }
        }

        public void eliminarRegistro(int Codigo)
        {
            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "DELETE FROM Productos WHERE Codigo = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", Codigo);

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con el código especificado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el producto: " + ex.Message);
                }
            }
        }


        public void BuscarProducto(DataGridView dgvUsuariosRegistrados)
        {
            dgvUsuariosRegistrados.Rows.Clear();
            dgvUsuariosRegistrados.Columns.Clear();

            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {

                    DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                    btnEditar.Name = "btnEditar";
                    btnEditar.HeaderText = "Editar";
                    btnEditar.Text = "Editar";
                    btnEditar.UseColumnTextForButtonValue = true;
                    dgvUsuariosRegistrados.Columns.Add(btnEditar);

                    DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    btnEliminar.Name = "btnEliminar";
                    btnEliminar.HeaderText = "Eliminar";
                    btnEliminar.Text = "Eliminar";
                    btnEliminar.UseColumnTextForButtonValue = true;
                    dgvUsuariosRegistrados.Columns.Add(btnEliminar);

                    conexion.Open();

                    string query = "SELECT Fecha, User_id, Tiempo_de_uso FROM Auditoria";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {


                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            dgvUsuariosRegistrados.Rows.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    dgvUsuariosRegistrados.Rows.Add(reader["Nombre"], reader["Precio"], reader["Stock"], reader["Categoria"]);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros para el usuario 'admin'.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
    }
}
