using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    public interface ILoggerGeneral
    {
        // Método para imprimir un mensaje por consola
        void Mesagge(string message);

        // Imiprimir un log
        bool LogDatabase(string message);
        // Hace un retiro dependiendo de la condición
        bool LogBalanceDespuesRetiro(int balanceDespuesRetiro);


        string MessaggeWithReturnString(string message);

        bool MessaggeWithOutParameterReturnString(string str, out string outputStr);

    }
    // Esta clase implementa la Interfaz IllogerGeneral
    public class LoggerGeneral : ILoggerGeneral
    {
        public bool LogBalanceDespuesRetiro(int balanceDespuesRetiro)
        {
            // SI es mayor a zero 
            if (balanceDespuesRetiro >= 0)
            {
                Console.WriteLine("Exito operacion");
                return true;
            }
            Console.WriteLine("Error.");
            return false;
        }

        public bool LogDatabase(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        // Imprime por consola un mensaje
        public void Mesagge(string message)
        {
            Console.WriteLine(message);
        }


        // Cualquier cadena que llegue, esta función la imprimirá y la retornará en minuscula
        public string MessaggeWithReturnString(string message)
        {
            Console.WriteLine(message);
            return message.ToLower();
        }

        public bool MessaggeWithOutParameterReturnString(string str, out string outputStr)
        {
            outputStr = "Hola" + str;
            return true;
        }


    }

    // Objeto Falso
    public class LoggerFake : ILoggerGeneral
    {
        
        public bool LogBalanceDespuesRetiro(int balanceDespuesRetiro)
        {
            return false;
        }
        
        public bool LogDatabase(string message)
        {
            return false;
        }

        // Imprime por consola un mensaje
        public void Mesagge(string message)
        {
        }

        public string MessaggeWithReturnString(string message)
        {
            return message;
        }

        public bool MessaggeWithOutParameterReturnString(string message, out string outputStr)
        {
            outputStr = "";
            return true;
        }

    }
}
