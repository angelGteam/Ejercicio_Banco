using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class BankAccount {
        public int AccountNumber { get => AccountNumber; set => AccountNumber = value; }
        public int Balance { get => Balance; set => Balance = value; }
        public BankAccount(int accountNumber, int balance) {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
   
}
