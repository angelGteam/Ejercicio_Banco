using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class EmployeeService {
        /// <summary>
        /// un empleado hace un prestamo para un usuario, ya sea otro empleado, o un cliente
        /// </summary>
        /// <param name="employee"></param>
        /// <param name="Quantity"></param>
        /// <param name="user"></param>
        public static void Loan(Employee employee, int Quantity, User user) {
            BankAccountService bankAccountService = new BankAccountService();
            user.BankAccount.Balance = bankAccountService.IncreaseBalance(user.BankAccount, Quantity);
            Console.WriteLine("El cliente con el ID: {0}, va a realizar un prestamo por el valor de: {1}, con un interés del: {2} %", user.UserID, Quantity, CalculateInterest(Quantity));
        }
        
        /// <summary>
        /// Registra el usuario
        /// </summary>
        /// <param name="Employee"></param>
        public static void Register(Employee Employee, EmailResponseService emailResponseService) {
            Console.WriteLine("Se ha registrado el usuario: " + Employee.Name + ", con el IDUsuario: " + Employee.UserID + ", y la contraseña: " + Employee.Password + ".");
            if(EmailResponseService.CheckPassword())
            {
                emailResponseService.SendMessage(Employee.Mail);
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
        /// <param name="Employee"></param>
        /// <returns></returns>
        public static bool CheckPermissions(Employee Employee) {
            if(Employee.Permission == 1) {
                return true;
            } else if(Employee.Permission == 0) {
                return false;
            } else {
                return false; // Hacer excepcion de user no valido en su lugar
            }

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
    }
}
