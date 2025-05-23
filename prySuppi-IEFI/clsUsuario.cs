using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace prySuppi_IEFI
{
    internal class clsUsuario
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDS;

        string rutaArchivo;
        public string estadoConexion;


        public clsUsuario()
        {
            try
            {
                rutaArchivo = @"../../UsuarioDatabase/Usuarios.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + rutaArchivo;
                conexionBD.Open();

                objDS = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }

           
        }

        public void InsertarAuditoria(string name)
        {
            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Auditoria";

                OleDbDataAdapter adaptadorBD = new OleDbDataAdapter(comandoBD);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adaptadorBD);

                DataSet objDS = new DataSet();
                adaptadorBD.Fill(objDS, "Auditoria");

                DataTable objTabla = objDS.Tables["Auditoria"];
                DataRow nuevoRegistro = objTabla.NewRow();

                nuevoRegistro["UserId"] = name;
                nuevoRegistro["Fecha"] = DateTime.Now;
                nuevoRegistro["Tiempo de uso"] = 10000;

                objTabla.Rows.Add(nuevoRegistro);

                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDS, "Auditoria");

                estadoConexion = "Exito";

            }
            catch (Exception error)
            {
                estadoConexion = error.Message;
            }
        }
        public void ValidarUsuario(string name, string pass)
        {
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
                        }
                    }
                }

            }
            catch (Exception error)
            {

                estadoConexion = error.Message;
            }
        }
    }
}
