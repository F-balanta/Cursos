using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosVarios
{
    class AvisosTrafico : IAvisos
    {

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion Cometida, Pague antes de 3 días y se beneficiara de una reduccion de la sancion del 50%";
            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this .mensaje = mensaje;
            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine($"Mensaje: {mensaje} ha sido enviado por {remitente} el dia {fecha}");
        }



        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
