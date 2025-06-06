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
           
            ValidationOpt(user, dgvAudtioria);
        }


        public void ValidationOpt(string user, DataGridView dgvAudtioria)
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

            if (OptResumen.Checked)
            {
                buscarProductoPorUsuario(user, dgvAudtioria);
            }
        }
            

        public void buscarProductoPorUsuario(string user, DataGridView dgvAudtioria)
        {
            connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;


            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "SELECT Id, User_id, Fecha, Tiempo_de_uso  FROM Auditoria WHERE User_id = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", user);

                        using (OleDbDataReader lector = comando.ExecuteReader())
                        {
                            while (lector.Read())
                            {
                                string id = lector["Id"].ToString();
                                string userId = lector["User_id"].ToString();
                                string fecha = lector["Fecha"].ToString();
                                string tiempoDeUso = lector["Tiempo_de_uso"].ToString();

                                dgvAudtioria.Rows.Add(id, fecha, userId, tiempoDeUso);

                                Console.WriteLine($"Usuario: {user}, Fecha: {fecha}, Tiempo de uso: {tiempoDeUso}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al obtener datos de auditoría: " + ex.Message);
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

            string query = "SELECT Id, Fecha, User_id, Tiempo_de_uso FROM Auditoria";

            using (OleDbCommand comando = new OleDbCommand(query, conexion))
            using (OleDbDataReader lector = comando.ExecuteReader())
            {
                while (lector.Read())
                {
                    string id = lector["Id"].ToString();
                    string userId = lector["User_id"].ToString();
                    string fecha = lector["Fecha"].ToString();
                    string tiempoDeUso = lector["Tiempo_de_uso"].ToString();

                            dgvAudtioria.Rows.Add(id, fecha, userId, tiempoDeUso);

                            Console.WriteLine($"Usuario: {userId}, Fecha: {fecha}, Tiempo de uso: {tiempoDeUso}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al obtener datos de auditoría: " + ex.Message);
        }
            }
        }

    }
}
