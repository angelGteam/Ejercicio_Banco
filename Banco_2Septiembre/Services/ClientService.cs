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
        /// <param name="userable"></param>
        public void Loan(IUserable userable) {
        
        }
        /// <summary>
        /// Iniciar la sesion de un usuario ya creado (extra que no pedido que prefiero no borrar para cambios futuros)
        /// </summary>
        /// <param name="userable"></param>
        public static void Login(IUserable userable) {
            if(EmailResponseService.CheckPassword())
            {
                Console.WriteLine("Logueado el usuario: " + userable.UserID);
            }
        }
        // TODO: 
        /// <summary>
        /// Registra el usuario
        /// </summary>
        /// <param name="userable"></param>
        public static void Register(IUserable userable) {
            Console.WriteLine("Se ha registrado el usuario: " + userable.Name + ", con el IDUsuario" + userable.UserID + ", y la contraseña: " + userable.Password + ".");
            if(EmailResponseService.CheckPassword()) {
                EmailResponseService.SendMessage(userable.Mail);
            }           
        }
        /// <summary>
        /// Realiza una transferencia, de un usuario A, a un usuario B
        /// </summary>
        /// <param name="userable1"></param>
        /// <param name="userable2"></param>
        /// <param name="quantity"></param>
        public static void Transference(IUserable userable1, IUserable userable2, int quantity) {
            BankAccountService.ReduceBalance(userable1.BankAccount, quantity);
            BankAccountService.IncreseBalance(userable1.BankAccount, quantity);
            SMSResponseService.SendMessage(quantity, userable1.PhoneNumber, userable2.PhoneNumber);
        }
        /// <summary>
        /// Comprueba los persmisos asignados al cliente
        /// </summary>
        /// <param name="userable"></param>
        /// <returns></returns>
        public static bool CheckPermissions(IUserable userable) {
            if(userable.permission==1) {
                return true;
            } else if(userable.permission == 0) {
                return false;
            } else {
                return false; // Hacer excepcion de user no valido en su lugar
            }
          
        }
    }
}
