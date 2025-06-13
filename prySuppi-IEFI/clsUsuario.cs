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

        clsConexion conexionDatabase = new clsConexion();


        public void ConteoDeTiempo()
        {
        }

        public string EstadoDeConeccion()
        {
            return conexionDatabase.estadoConexion;
        }

        public void InsertarAuditoria(string name)
        {

            using (OleDbConnection conexion = new OleDbConnection(conexionDatabase.connectionString))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Auditoria (User_id, Fecha, Tiempo_de_uso) VALUES (?, ?, ?)";


                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", name);
                        comando.Parameters.AddWithValue("?", DateTime.Today.ToString("dd/MM/yyyy"));
                        comando.Parameters.AddWithValue("?", 1000);

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
                conexionDatabase.comandoBD = new OleDbCommand();

                conexionDatabase.comandoBD.Connection = conexionDatabase.conexionBD;
                conexionDatabase.comandoBD.CommandType = System.Data.CommandType.TableDirect;
                conexionDatabase.comandoBD.CommandText = "Usuarios";

                conexionDatabase.lectorBD = conexionDatabase.comandoBD.ExecuteReader();

                

                if (conexionDatabase.lectorBD.HasRows)
                {
                    while (conexionDatabase.lectorBD.Read())
                    {
                        if (conexionDatabase.lectorBD[1].ToString() == name && conexionDatabase.lectorBD[2].ToString() == pass)
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
