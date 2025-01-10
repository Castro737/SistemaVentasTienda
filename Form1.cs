using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace SistemaVentasTienda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtiene la cadena de conexión desde App.config
                string connectionString = ConfigurationManager.ConnectionStrings["SistemaVentasTienda"].ConnectionString;


                // Consulta SQL para obtener los datos
                string query = "SELECT * FROM Clientes";

                // Crea la conexión y llena el DataTable
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Asigna el DataTable como origen de datos del DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
