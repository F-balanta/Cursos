using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConecionGestionPedidos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Cadena de conexion que permite enlazar la base de datos con el proyecto
            string miconexion = ConfigurationManager.ConnectionStrings["ConecionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miconexion);
            MuestraClientes();
        }
        

        // Este metodo mostrara los nombres de los clientes en un listBox
        private void MuestraClientes()
        {
            string consulta = "SELECT * FROM CLIENTE";
            // Son un conjunto de comandos y una conexion de base de datos que se utiliza
            // para llenar un DataSet(Conjuntode datos) y actualizar la base de datos
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);
            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();

                miAdaptadorSql.Fill(clientesTabla);
                listaClientes.DisplayMemberPath = "nombre";
                listaClientes.SelectedValuePath = "Id";
                listaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }
           
        private void MuestraPedidos()
        {
            // Se crea una consulta parametrica
            string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.cCliente" + " WHERE C.ID=@ClienteId";

            SqlCommand sqlComando = new SqlCommand(consulta,miConexionSql);
            // Devuelve los registros de una consulta parametrica
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);
            using (miAdaptadorSql)
            {
                sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
                // Representa una tabla
                DataTable pedidosTabla = new DataTable();

                miAdaptadorSql.Fill(pedidosTabla);

                pedidosCliente.DisplayMemberPath = "fechaPedido";
                pedidosCliente.SelectedValuePath = "Id";
                pedidosCliente.ItemsSource = pedidosTabla.DefaultView;
            }
        }
        
        // Representa una conexion al servidor de base de datos
        SqlConnection miConexionSql;

        private void listaClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MuestraPedidos();
        }
    }
}
