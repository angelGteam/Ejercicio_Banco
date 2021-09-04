using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class ClientService : User {
        /// <summary>
        /// queda por hacer el prestamo
        /// </summary>
        /// <param name="userable"></param>
        public void Loan(User userable) {
        
        }
        /// <summary>
        /// Iniciar la sesion de un usuario ya creado (extra que no pedido que prefiero no borrar para cambios futuros)
        /// </summary>
        /// <param name="userable"></param>
        public static void Login(Client userable) {
            if(EmailResponseService.CheckPassword())
            {
                Console.WriteLine("Logueado el usuario: " + userable.UserID);
            }
        }
        // TODO: 
        /// <summary>
        /// Registra el usuario
        /// </summary>
        /// <param name="user"></param>
        public static void Register(User user, EmailResponseService emailResponseService) {
            Console.WriteLine("Se ha registrado el usuario: " + user.Name + ", con el IDUsuario" + user.UserID + ", y la contraseña: " + user.Password + ".");
            if(EmailResponseService.CheckPassword()) {
                emailResponseService.SendMessage(user.Mail);
            }           
        }
        /// <summary>
        /// Realiza una transferencia, de un usuario A, a un usuario B
        /// </summary>
        /// <param name="userable1"></param>
        /// <param name="userable2"></param>
        /// <param name="quantity"></param>
        public static void Transference(User userable1, User userable2, int quantity, SMSResponseService smsResponseService) {
            BankAccountService.ReduceBalance(userable1.BankAccount, quantity);
            BankAccountService.IncreseBalance(userable1.BankAccount, quantity);
            smsResponseService.SendMessage(quantity, userable1.PhoneNumber, userable2.PhoneNumber);
        }
        /// <summary>
        /// Comprueba los persmisos asignados al cliente
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool CheckPermissions(User user) {
            if(user.permission==1) {
                return true;
            } else if(user.permission == 0) {
                return false;
            } else {
                return false; // Hacer excepcion de user no valido en su lugar
            }
          
        }
    }
}
