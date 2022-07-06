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

namespace ListBoxPractica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> listaPob = new List<Poblaciones>();

            listaPob.Add(new Poblaciones() { poblacion1 = "Madrid", poblacion2 = "Barcelona", Temperatura1 = 15, Temperatura2 = 17, DiferenciaTemp = 2});
            listaPob.Add(new Poblaciones() { poblacion1 = "Valencia", poblacion2 = "Alicante", Temperatura1 = 19, Temperatura2 = 12, DiferenciaTemp = 7});
            listaPob.Add(new Poblaciones() { poblacion1 = "Malaga", poblacion2 = "Bilbao", Temperatura1 = 20, Temperatura2 = 26, DiferenciaTemp = 6 });
            listaPob.Add(new Poblaciones() { poblacion1 = "Sevilla", poblacion2 = "Coruña", Temperatura1 = 22, Temperatura2 = 50, DiferenciaTemp = 28});

            ListaPoblaciones.ItemsSource = listaPob;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem != null)
            {
                MessageBox.Show((ListaPoblaciones.SelectedItem as Poblaciones).poblacion1 + " " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + " °C" +
                    (ListaPoblaciones.SelectedItem as Poblaciones).poblacion2 + " " +
                    (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + " °C" +
                    "\nDiferencia Temp(" + (ListaPoblaciones.SelectedItem as Poblaciones).DiferenciaTemp + ")");
            }
            else
            {
                MessageBox.Show("No has seleccionado ningun Item");
            }
        }
    }

    public class Poblaciones
    {
        public string poblacion1 { get; set; }
        public int Temperatura1 { get; set; }
        public string poblacion2 { get; set; }
        public int Temperatura2 { get; set; }
        public int DiferenciaTemp { get; set; }
    }
}