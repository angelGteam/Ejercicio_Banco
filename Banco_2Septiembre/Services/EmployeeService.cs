using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class EmployeeService {
        /// <summary>
        /// queda por hacer el prestamo
        /// </summary>
        /// <param name="client"></param>
        public void Loan(Employee employee) {
            
        }
        /// <summary>
        /// Iniciar la sesion de un usuario ya creado (extra que no pedido que prefiero no borrar para cambios futuros)
        /// </summary>
        /// <param name="Employee"></param>
        public static void Login(Employee Employee) {
            if(EmailResponseService.CheckPassword()) {
                Console.WriteLine("Logueado el usuario: " + Employee.UserID);
            }
        }
        /// <summary>
        /// Registra el usuario
        /// </summary>
        /// <param name="Employee"></param>
        public static void Register(Employee Employee, EmailResponseService emailResponseService) {
            Console.WriteLine("Se ha registrado el usuario: " + Employee.Name + ", con el IDUsuario" + Employee.UserID + ", y la contraseña: " + Employee.Password + ".");
            if(EmailResponseService.CheckPassword())
            {
                emailResponseService.SendMessage(Employee.Mail);
            }
        }
        /// <summary>
        /// Realiza una transferencia, de un usuario A, a un usuario B
        /// </summary>
        /// <param name="Employee1"></param>
        /// <param name="Employee2"></param>
        /// <param name="Quantity"></param>
        public void Transference(Employee Employee1, Employee Employee2, int Quantity, SMSResponseService smsResponseService) {
            BankAccountService.ReduceBalance(Employee1.BankAccount, Quantity);
            BankAccountService.IncreseBalance(Employee2.BankAccount, Quantity);
            smsResponseService.SendMessage(100, Employee1.PhoneNumber, Employee2.PhoneNumber);
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
    }
}
