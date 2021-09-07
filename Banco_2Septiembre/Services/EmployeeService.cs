using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using Banco_Ejercicio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class EmployeeService : User, Iuserable {
        #region "Metodos usuario basico"
        /// <summary>
        /// Registra el usuario
        /// </summary>
        /// <param name="Employee"></param>
        public void Register(User User, EmailResponseService emailResponseService) {
            Console.WriteLine("Se ha registrado el usuario: " + User.Name + ", con el IDUsuario: " + User.UserID + ", y la contraseña: " + User.Password + ".");
            if(EmailResponseService.CheckPassword()) {
                emailResponseService.SendMessage(User.Mail);
            }
        }
        /// <summary>
        /// Realiza una transferencia, de un usuario A, a un usuario B
        /// </summary>
        /// <param name="User1"></param>
        /// <param name="User2"></param>
        /// <param name="Quantity"></param>
        public void Transference(User User1, User User2, int Quantity, SMSResponseService smsResponseService) {
            BankAccountService bankAccountService = new BankAccountService();
            User1.BankAccount.Balance = bankAccountService.ReduceBalance(User1.BankAccount, Quantity);
            User2.BankAccount.Balance = bankAccountService.IncreaseBalance(User2.BankAccount, Quantity);
            smsResponseService.SendMessage(100, User1.BankAccount, User2.BankAccount);
        }
        /// <summary>
        /// Comprueba los persmisos asignados al cliente
        /// </summary>
        /// <param name="User"></param>
        /// <returns></returns>
        public bool CheckPermissions(User User) {
            if(User.Permission == 1) {
                return true;
            } else if(User.Permission == 0) {
                return false;
            } else {
                return false; // Hacer excepcion de user no valido en su lugar
            }

        }
        #endregion
        #region "Metodos propios del Employee"
        /// <summary>
        /// un empleado hace un prestamo para un usuario, ya sea otro empleado, o un cliente
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="Quantity"></param>
        /// <param name="user"></param>
        public void Loan(Employee employee, int Quantity, User user) {
            BankAccountService bankAccountService = new BankAccountService();
            user.BankAccount.Balance = bankAccountService.IncreaseBalance(user.BankAccount, Quantity);
            Console.WriteLine("El cliente con el ID: {0}, va a realizar un prestamo por el valor de: {1}, con un interés del: {2} %", user.UserID, Quantity, CalculateInterest(Quantity));
        }
        private static int CalculateInterest(int QuantityOfLoan) {
            int ret;
            if(QuantityOfLoan <= 100) {
                ret = 5;
            } else if(QuantityOfLoan > 100 && QuantityOfLoan <= 200) {
                ret = 10;
            } else if(QuantityOfLoan > 200 && QuantityOfLoan <= 300) {
                ret = 15;
            } else {
                ret = 20;
            }


            return ret;
        }
        #endregion
    }
}
