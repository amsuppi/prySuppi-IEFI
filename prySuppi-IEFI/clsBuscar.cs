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

        public RadioButton OptDetalle;
        public RadioButton OptResumen;

        clsConexion clsConexion = new clsConexion();


        public clsBuscar(RadioButton optDetalle, RadioButton optResumen)
        {
            this.OptDetalle = optDetalle;
            this.OptResumen = optResumen;
        }

        public void setearDatosEnDataGrid(string user, DataGridView dgvAudtioria)
        {
            dgvAudtioria.Rows.Clear();
            dgvAudtioria.Columns.Clear();

            dgvAudtioria.Columns.Add("Id", "Id");
            dgvAudtioria.Columns.Add("Fecha", "Fecha");
            dgvAudtioria.Columns.Add("User_id", "User Id");
            dgvAudtioria.Columns.Add("Tiempo_de_uso", "Tipo de uso");

            if (OptDetalle.Checked)
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

            using (OleDbConnection conexion = new OleDbConnection(clsConexion.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT Fecha, User_id, Tiempo_de_uso FROM Auditoria WHERE User_id = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {

                        comando.Parameters.AddWithValue("?", user);

                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            dgvAudtioria.Rows.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string fecha = reader["Fecha"].ToString();
                                    string userId = reader["User_id"].ToString();
                                    int tiempoDeUso = Convert.ToInt32(reader["Tiempo_de_uso"]);

                                    Console.WriteLine($"Fecha: {fecha}, User_id: {userId}, Tiempo: {tiempoDeUso}");

                                    dgvAudtioria.Rows.Add(fecha, userId, tiempoDeUso);
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
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }

        public void buscarProductoGeneral(DataGridView dgvAudtioria)
        {
            using (OleDbConnection conexion = new OleDbConnection(clsConexion.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT Fecha, User_id, Tiempo_de_uso FROM Auditoria";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        using (OleDbDataReader reader = comando.ExecuteReader())
                        {
                            dgvAudtioria.Rows.Clear();

                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string fecha = reader["Fecha"].ToString();
                                    string userId = reader["User_id"].ToString();
                                    int tiempoDeUso = Convert.ToInt32(reader["Tiempo_de_uso"]);

                                    Console.WriteLine($"Fecha: {fecha}, User_id: {userId}, Tiempo: {tiempoDeUso}");

                                    dgvAudtioria.Rows.Add(fecha, userId, tiempoDeUso);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron registros en la tabla Auditoria.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

    }
}
