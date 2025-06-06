using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySuppi_IEFI
{
    public class clsBuscar
    {
        string rutaArchivo = @"../../UsuarioDatabase/Usuarios.accdb";
        string connectionString;

        public RadioButton OptDetalle;
        public RadioButton OptResumen;


        public clsBuscar(RadioButton optDetalle, RadioButton optResumen)
        {
            this.OptDetalle = optDetalle;
            this.OptResumen = optResumen;
        }

        public void setearDatosEnDataGrid(string user, DataGridView dgvAudtioria)
        {
            if(OptDetalle.Checked)
            {
                buscarProductoGeneral(dgvAudtioria);
            }

            if(OptResumen.Checked)
            {
                buscarProductoPorUsuario(user, dgvAudtioria);
            }
        }

        public void buscarProductoPorUsuario(string user, DataGridView dgvAudtioria)
        {
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;

            dgvAudtioria.Rows.Clear();
            dgvAudtioria.Columns.Clear();

            dgvAudtioria.Columns.Add("Id", "Id");
            dgvAudtioria.Columns.Add("Fecha", "Fecha");
            dgvAudtioria.Columns.Add("User_id", "User Id");
            dgvAudtioria.Columns.Add("Tiempo_de_uso", "Tipo de uso");
            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Consulta para buscar productos por categoría
                    string query = "SELECT Id, Fecha, User_id, Tiempo_de_uso FROM Auditoria WHERE User_id = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        // Se especifica el tipo de parámetro, si es texto, se utiliza OleDbType.VarChar
                        comando.Parameters.AddWithValue("?", user);

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar filas anteriores en el DataGridView
                            dgvAudtioria.Rows.Clear();

                           
                            // Si el reader tiene datos, los recorremos y los mostramos
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {

                                    MessageBox.Show("Reader" + reader);
                                    //string id = reader.GetInt32(0).ToString();
                                    //string fecha = reader.GetDateTime(1).ToString();
                                    //string User_id = reader.GetString(2).ToString();
                                    //string Tiempo_de_uso = reader.GetInt32(3).ToString();


                                    // Añadir la fila al DataGridView
                                    //dgvAudtioria.Rows.Add(id, fecha, User_id, Tiempo_de_uso);
                                }
                            }
                            else
                            {
                                // Si no se encontraron productos, mostramos un mensaje
                                MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar cualquier error en la consola
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void buscarProductoGeneral(DataGridView dgvAudtioria)
        {
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Consulta para buscar productos por categoría
                    string query = "SELECT Fecha, User_id, Tiempo_de_uso FROM Auditoria";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            // Limpiar filas anteriores en el DataGridView
                            dgvAudtioria.Rows.Clear();

                            // Si el reader tiene datos, los recorremos y los mostramos
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int id = reader.GetInt32(0);
                                    string fecha = reader.GetString(1);
                                    string User_id = reader.GetString(2);
                                    string Tiempo_de_uso = reader.GetString(3);


                                    // Añadir la fila al DataGridView
                                    dgvAudtioria.Rows.Add(id, fecha, User_id, Tiempo_de_uso);
                                }
                            }
                            else
                            {
                                // Si no se encontraron productos, mostramos un mensaje
                                MessageBox.Show("No se encontraron productos que coincidan con la búsqueda.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar cualquier error en la consola
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

    }
}
