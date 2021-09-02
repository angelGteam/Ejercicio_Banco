using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Servicios;
using System;

namespace Banco_2Septiembre {
    class Bank {
        static void Main(string[] args) {
            Email ClientMail = new Email("aGomez@gteam.com", "password123");
            Email EmployeeMail = new Email("rPerez@gteam.com", "password123");
            SMSResponse Clientnumber = new SMSResponse(665665665);
            SMSResponse Employeenumber = new SMSResponse(556556556);
            BankAccount ClientBankAccount = new BankAccount(123456789, 1000);
            BankAccount EmployeeBankAccount = new BankAccount(123456788, 1000);

            Client client1 = new Client("Client1ID", "Angel Gomez", "Password123", ClientMail, Clientnumber, ClientBankAccount);
            Employee employee1 = new Employee("Employee1ID", "Rodolfo Perez", "Password123", EmployeeMail, Employeenumber, EmployeeBankAccount);

            ClientService.Register(client1);

            

        }
    }
}
