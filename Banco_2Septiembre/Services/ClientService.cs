using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class ClientService : IUserable {
        /// <summary>
        /// queda por hacer el prestamo
        /// </summary>
        /// <param name="client"></param>
        public void Loan(Client client) {
        
        }
        /// <summary>
        /// Iniciar la sesion de un usuario ya creado (extra que no pedido que prefiero no borrar para cambios futuros)
        /// </summary>
        /// <param name="client"></param>
        public static void Login(Client client) {
            if(EmailService.CheckPassword())
            {
                Console.WriteLine("Logueado el usuario: " + client.UserID);
            }
        }
        /// <summary>
        /// Registra el usuario
        /// </summary>
        /// <param name="client"></param>
        public static void Register(Client client) {
            Console.WriteLine("Se ha registrado el usuario: " + client.Name + ", con el IDUsuario" + client.UserID + ", y la contraseña: " + client.Password + ".");
            if(EmailService.CheckPassword()) {
                EmailService.SendMessage(client.Mail);
            }           
        }
        /// <summary>
        /// Realiza una transferencia, de un usuario A, a un usuario B
        /// </summary>
        /// <param name="user1"></param>
        /// <param name="user2"></param>
        /// <param name="quantity"></param>
        public static void Transference(Client user1, Client user2, int quantity) {
            BankAccountService.ReduceBalance(user1.BankAccount, quantity);
            BankAccountService.IncreseBalance(user2.BankAccount, quantity);
            SMSResponseService.SendMessage(quantity, user1.PhoneNumber, user2.PhoneNumber);
        }
        /// <summary>
        /// Comprueba los persmisos asignados al cliente
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public static bool CheckPermissions(Client client) {
            if(client.permission==1) {
                return true;
            } else if(client.permission == 0) {
                return false;
            } else {
                return false; // Hacer excepcion de user no valido en su lugar
            }
          
        }
    }
}
