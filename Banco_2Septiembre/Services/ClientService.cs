using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class ClientService : User {
        public void Loan(Client client) {
        //queda por hacer
        }

        public static void Login(Client client) {
            if(EmailService.CheckPassword())
            {
                Console.WriteLine("Logueado el usuario: " + client.UserID);
            }
        }
        public static void Register(Client client) {
            Console.WriteLine("Se ha registrado el usuario: " + client.Name + ", con el IDUsuario" + client.UserID + ", y la contraseña: " + client.Password + ".");
            if(EmailService.CheckPassword()) {
                EmailService.SendCredentials(client.Mail);
            }           
        }

        public void Transference(Client user1, Client user2, int cantidad) {
            BankAccountService.ReduceBalance(user1.BankAccount, cantidad);
            BankAccountService.IncreseBalance(user2.BankAccount, cantidad);
            SMSResponseService.SendMessage(100, user1.PhoneNumber, user2.PhoneNumber);
        }
        public static Boolean CheckPermissions(User user) {
            return true;
        }
    }
}
