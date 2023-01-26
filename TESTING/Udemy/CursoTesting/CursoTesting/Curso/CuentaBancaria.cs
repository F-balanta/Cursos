using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso
{
    public class CuentaBancaria
    {
        private readonly ILoggerGeneral _loggerGeneral;

        public int Balance{ get; set; }

        // Método contructor para inicializar el balance
        public CuentaBancaria(ILoggerGeneral loggerGeneral)
        {
            Balance = 0;
            _loggerGeneral = loggerGeneral;
        }


        //Metodo para hacer depositos sobre la una cuenta bancaria
        // Retorna un booleano ya que la transacicon de un deposito puede llevarse a cabo o puede
        // tener ciertos erroes y fallar, por eso necesitaré un dato que indique si fué exitoso o no.
        public bool Deposito(int monto)
        {
            _loggerGeneral.Mesagge($"Esta depositando la cantidad de {monto}");
            Balance += monto;
            return true;
        }
        // Método para hacer retiros de la cuentabancaria
        public bool Retiro(int monto)
        {
            // Si el monto es menor al balance que hay en la cuenta, el retiro se podrá hacer
            if (monto <= Balance)
            {
                _loggerGeneral.LogDatabase($"Monto de retiro: {monto}");
                Balance -= monto;

                return _loggerGeneral.LogBalanceDespuesRetiro(Balance);
            }
            
            return _loggerGeneral.LogBalanceDespuesRetiro(Balance - monto);
        }

        // Metodo para obtener el balance
        public int GetBalance()
        {
            _loggerGeneral.Mesagge($"Su balance es de: {Balance}");
            return Balance;
        }
    }
}
