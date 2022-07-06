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

namespace CRUD_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();
            //Cadena de conexion es = NOMBRE_DEL_PROYECTO.Properties.Settings.NOMBRE_CADENA_DE_CONEXION_CON_LA_BBDD
            string miConexion = ConfigurationManager.ConnectionStrings["CRUD_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;

            // Data content es una representacion ORM ligero de nuestra base de datos --- Mapeo de la base de datos

            dataContext = new DataClasses1DataContext(miConexion);

        }
        public void InsertaEmpresas()
        {
            Empresa pildorasInformaticas = new Empresa();
            pildorasInformaticas.Nombre = "Pildoras Informaticas";
        }
    }
}
