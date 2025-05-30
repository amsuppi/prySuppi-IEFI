using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Windows.Forms;
using System.Diagnostics;


namespace prySuppi_IEFI
{
    internal class clsUsuario
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        DataSet objDS;

        string rutaArchivo= @"../../UsuarioDatabase/Usuarios.accdb";
        public string estadoConexion;

        private Stopwatch cronometro = new Stopwatch();

        string connectionString;

        public clsUsuario()
        {
            try
            {
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = connectionString;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }

           
        }

        public void ConteoDeTiempo()
        {
            cronometro.Restart();
        }

        public void InsertarAuditoria(string name)
        {

            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Auditoria (User_id, Fecha, Tiempo_de_uso) VALUES (?, ?, ?)";

                    cronometro.Stop();
                    TimeSpan tiempoTranscurrido = cronometro.Elapsed;

                    MessageBox.Show($"Tiempo transcurrido: {tiempoTranscurrido.TotalSeconds} segundos");
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", name);
                        comando.Parameters.AddWithValue("?", DateTime.Today.ToString("dd/MM/yyyy"));
                        comando.Parameters.AddWithValue("?", tiempoTranscurrido.TotalSeconds);

                        int filas = comando.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }
        public bool ValidarUsuario(string name, string pass)
        {
            bool flag = false;
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Usuarios";

                lectorBD = comandoBD.ExecuteReader();

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD[1].ToString() == name && lectorBD[2].ToString() == pass)
                        {
                            InsertarAuditoria(name);
                            flag = true;
                        }
                    }
                }
                

            }
            catch (Exception error)
            {
                MessageBox.Show("Error" + error);
                flag = false;
            }

            return flag;
        }
       
    }
}
