using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using Banco_2Septiembre.Servicios;
using System;

namespace Banco_2Septiembre {
    class Bank {
        static void Main(string[] args) {
            Email ClientMail = new Email("aGomez@gteam.com", "password123");
            Email EmployeeMail = new Email("rPerez@gteam.com", "password123");
            BankAccount ClientBankAccount = new BankAccount(123456789, 1000);
            BankAccount EmployeeBankAccount = new BankAccount(123456788, 1000);

            Client client1 = new Client("Client1ID", "Angel Gomez", "Password123", ClientMail, 665665665, ClientBankAccount);
            Client client2 = new Client("Client1ID", "Angel Gomez", "Password123", ClientMail, 665665665, ClientBankAccount);
            Employee employee1 = new Employee("Employee1ID", "Rodolfo Perez", "Password123", EmployeeMail, 556556556, EmployeeBankAccount);
            EmailResponseService emailResponseService = new EmailResponseService();
            SMSResponseService smsResponseService = new SMSResponseService();
            ClientService.Register(client1, emailResponseService);
            ClientService.Login(client1);
            if(ClientService.CheckPermissions(client1)) {
                ClientService.Transference(client1, employee1, 100, smsResponseService);
            }       
        }
    }
}
