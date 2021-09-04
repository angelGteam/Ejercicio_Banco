using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using Banco_2Septiembre.Servicios;
using System;

namespace Banco_2Septiembre {
    class Bank {
        static void Main(string[] args) {
            Email ClientMail = new Email("aGomez@gteam.com", "password123");
            Email EmployeeMail = new Email("rPerez@gteam.com", "password123");
            BankAccount ClientBankAccount1 = new BankAccount(123456789, 1000);
            BankAccount ClientBankAccount2 = new BankAccount(123456791, 1000);
            BankAccount EmployeeBankAccount1 = new BankAccount(123456790, 1000);
            BankAccount EmployeeBankAccount2 = new BankAccount(123456788, 1000);

            Client client1 = new Client("Client1ID", "Angel Gomez", "Password123", ClientMail, 665665665, ClientBankAccount1);
            Client client2 = new Client("Client1ID", "Jorge Sancho", "Password123", ClientMail, 665665666, ClientBankAccount2);
            Employee employee1 = new Employee("Employee1ID", "Roberto Perez", "Password123", EmployeeMail, 556556557, EmployeeBankAccount1);
            Employee employee2 = new Employee("Employee2ID", "Raul Perez", "Password123", EmployeeMail, 556556556, EmployeeBankAccount2);
            
            EmailResponseService emailResponseService = new EmailResponseService();
            SMSResponseService smsResponseService = new SMSResponseService();
            
            ClientService.Register(client1, emailResponseService);
            EmployeeService.Register(employee1, emailResponseService);

            ClientService.Transference(client1, employee1, 100, smsResponseService);
            EmployeeService.Transference(employee1, employee2, 100, smsResponseService);
            if(EmployeeService.CheckPermissions(employee1)) {
                Console.WriteLine("Escriba la cantidad de dinero que desea ");
                string instruction = Console.ReadLine();
                int result = Int32.Parse(instruction);
                EmployeeService.Loan(employee2, result, client2);
            }
        }
    }
}
