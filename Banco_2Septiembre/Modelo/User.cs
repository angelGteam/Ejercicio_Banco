using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Interfaces {
    abstract class User {
        public string UserID;
        public string Name;
        public string Password;
        public Email Mail;
        public int PhoneNumber;
        public BankAccount BankAccount;
        public int permission;

    }
}
