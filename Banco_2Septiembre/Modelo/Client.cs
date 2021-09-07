using Banco_2Septiembre.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class Client : User {
        #region "Constructor"
        public Client(string userID, string name, string password, Email mail, int phoneNumber, BankAccount bankAccount) {
            UserID = userID;
            Name = name;
            Password = password;
            Mail = mail;
            PhoneNumber = phoneNumber;
            BankAccount = bankAccount;
            Permission = 0;
        }
        #endregion
    }
}
