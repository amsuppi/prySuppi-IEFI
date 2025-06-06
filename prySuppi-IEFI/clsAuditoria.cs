using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySuppi_IEFI
{
    internal class clsAuditoria
    {

        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        DataSet objDS;

        string rutaArchivo = @"../../UsuarioDatabase/Usuarios.accdb";
        public string estadoConexion;

        string connectionString;

        public clsAuditoria()
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

        public void BuscarProducto(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("Nombre", "Nombre");
            dataGridView.Columns.Add("Precio", "Precio");
            dataGridView.Columns.Add("Stock", "Stock");
            dataGridView.Columns.Add("Categoria", "Categoria");

            using (SqlConnection connection = ObtenerConexion())
            {
                try
                {

                    DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                    btnEditar.Name = "btnEditar";
                    btnEditar.HeaderText = "Editar";
                    btnEditar.Text = "Editar";
                    btnEditar.UseColumnTextForButtonValue = true;
                    dataGridView.Columns.Add(btnEditar);

                    DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    btnEliminar.Name = "btnEliminar";
                    btnEliminar.HeaderText = "Eliminar";
                    btnEliminar.Text = "Eliminar";
                    btnEliminar.UseColumnTextForButtonValue = true;
                    dataGridView.Columns.Add(btnEliminar);

                    connection.Open();
                    string selectQuery = "SELECT P.Nombre, P.Precio, P.Stock, C.Nombre AS Categoria FROM Productos P JOIN Categorias C ON P.CategoriaId = C.Id";
                    SqlCommand cmd = new SqlCommand(selectQuery, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        dataGridView.Rows.Add(reader["Nombre"], reader["Precio"], reader["Stock"], reader["Categoria"]);

                    }
                    reader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Error al buscar producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
