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

        string connectionString;

        DateTime inicio;
        DateTime fin;

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
            inicio = DateTime.Now;
        }

        public void InsertarAuditoria(string name)
        {

            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Auditoria (User_id, Fecha, Tiempo_de_uso) VALUES (?, ?, ?)";


                    fin = DateTime.Now;
                    TimeSpan tiempoTranscurrido = this.fin - this.inicio;

              

                    string formato = string.Format("{0:D2}:{1:D2}:{2:D2}",
                         tiempoTranscurrido.Hours,
                         tiempoTranscurrido.Minutes,
                         tiempoTranscurrido.Seconds);

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", name);
                        comando.Parameters.AddWithValue("?", DateTime.Today.ToString("dd/MM/yyyy"));
                        comando.Parameters.AddWithValue("?", formato);

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
