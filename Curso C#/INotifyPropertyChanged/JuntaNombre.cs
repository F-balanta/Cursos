using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraInterfaz_3
{
    internal class JuntaNombre : INotifyPropertyChanged
    {


        private string nombre, apellido, nombre_completo;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
