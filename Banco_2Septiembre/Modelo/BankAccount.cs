using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class BankAccount {
        #region "variables"
        public int IBAN;
        public int Balance;
        #endregion
        #region "Constructor"
        public BankAccount(int IBAN, int balance) {
            this.IBAN = IBAN;
            Balance = balance;
        }
        #endregion
    }
}
