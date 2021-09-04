using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Services {
    class SMSResponseService : ISendable {

        /// <summary>
        /// Envia el mensaje al numero del usuario, con la información de la transferencia
        /// </summary>
        /// <param name="Quantity"></param>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        public void SendMessage(int Quantity, int Number1, int Number2) {
            Console.WriteLine(GetMessage());
            Console.WriteLine($"El usuario con el número de cuenta: {0} le ha realizado una transferencia de: {1} €, a la cuenta de: {2}", Number1, Quantity, Number2 );
        }

        public string GetMessage() {
            return "Se ha realizado la transferencia correctamente.";
        }
    }
}
