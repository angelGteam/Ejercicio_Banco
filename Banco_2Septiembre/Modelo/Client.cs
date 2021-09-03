using Banco_2Septiembre.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class Client {
        public string UserID;
        public string Name;
        public string Password;
        public Email Mail;
        public int PhoneNumber;
        public BankAccount BankAccount;
        public int permission;

        public Client(string userID, string name, string password, Email mail, int phoneNumber, BankAccount bankAccount) {
            UserID = userID;
            Name = name;
            Password = password;
            Mail = mail;
            PhoneNumber = phoneNumber;
            BankAccount = bankAccount;
            permission = 0;
        }

    }
}
