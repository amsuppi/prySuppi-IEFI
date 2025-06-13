using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySuppi_IEFI
{
    public class clsConexion
    {

        public OleDbConnection conexionBD;
        public OleDbCommand comandoBD;
        public OleDbDataReader lectorBD;

        DataSet objDS;

        string rutaArchivo = @"../../UsuarioDatabase/Usuarios.accdb";
        public string estadoConexion;

        public string connectionString;
        public clsConexion()
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
    }
}
