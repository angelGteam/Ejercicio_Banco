﻿using Banco_2Septiembre.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class Employee {
        public string UserID { get => UserID; set => UserID = value; }
        public string Name { get => Name; set => Name = value; }
        public string Password { get => Password; set => Password = value; }
        public Email Mail { get => Mail; set => Mail = value; }
        public int PhoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public BankAccount BankAccount { get => BankAccount; set => BankAccount = value; }
        public int Permission { get => Permission; set => Permission = value; }

        public Employee(string userID, string name, string password, Email mail, int phoneNumber, BankAccount bankAccount) {
            UserID = userID;
            Name = name;
            Password = password;
            Mail = mail;
            PhoneNumber = phoneNumber;
            BankAccount = bankAccount;
            Permission = 1;
        }
    }
}
