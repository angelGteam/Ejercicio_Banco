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
        /// <param name="User1"></param>
        /// <param name="User2"></param>
        /// <param name="Quantity"></param>
        public static void Transference(User User1, User User2, int Quantity, SMSResponseService smsResponseService) {
            BankAccountService bankAccountService = new BankAccountService();
            User1.BankAccount.Balance = bankAccountService.ReduceBalance(User1.BankAccount, Quantity);
            User2.BankAccount.Balance = bankAccountService.IncreaseBalance(User2.BankAccount, Quantity);
            smsResponseService.SendMessage(100, User1.BankAccount, User2.BankAccount);
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
