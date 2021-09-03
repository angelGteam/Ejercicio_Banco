using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Services {
    class SMSResponseService {
        /// <summary>
        /// Envia el mensaje al numero del usuario, con la información de la transferencia
        /// </summary>
        /// <param name="Quantity"></param>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public static void SendMessage(int Quantity, int Number1, int Number2) {
            Console.WriteLine("El usuario con el número de cuenta: " + Number1 + ", le ha realizado una transferencia de: " + Quantity + "€, a la cuenta de: " + Number2);
        }
    }
}
