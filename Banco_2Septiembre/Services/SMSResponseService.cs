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
        public void SendMessage(int Quantity, BankAccount bankAccount1, BankAccount bankAccount2) {
            Console.WriteLine(GetMessage());
            Console.WriteLine("Le has realizado una transferencia de: {0} euros al usuario con el IBAN: {1}", Quantity, bankAccount2.IBAN);
            Console.WriteLine("El usuario con el IBAN: {0} le ha realizado una transferencia de: {1}", bankAccount1.IBAN, Quantity);
            Console.WriteLine("El usuario con el número de cuenta: {0} tien un saldo de: {1}", bankAccount1.IBAN, bankAccount1.Balance);
            Console.WriteLine("El usuario con el número de cuenta: {0} tien un saldo de: {1}", bankAccount2.IBAN, bankAccount2.Balance);
        }

        public string GetMessage() {
            return "Se ha realizado la transferencia correctamente.";
        }
    }
}
