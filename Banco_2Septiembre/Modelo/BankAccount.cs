using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class BankAccount {
        public int IBAN;
        public int Balance;
        public BankAccount(int IBAN, int balance) {
            this.IBAN = IBAN;
            Balance = balance;
        }

    }
   
}
