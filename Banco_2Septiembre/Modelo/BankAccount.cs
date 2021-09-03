using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class BankAccount {
        public int IBAN { get => IBAN; set => IBAN = value; }
        public int Balance { get => Balance; set => Balance = value; }
        public BankAccount(int IBAN, int balance) {
            this.IBAN = IBAN;
            Balance = balance;
        }
    }
   
}
