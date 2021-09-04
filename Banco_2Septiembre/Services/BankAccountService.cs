using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class BankAccountService {
        /// <summary>
        /// Reduce el saldo de la cuenta
        /// </summary>
        /// <param name="BA"></param>
        /// <param name="quantity"></param>
        public int ReduceBalance(BankAccount BA, int quantity) {
            BA.Balance -= quantity;
            return BA.Balance;
        }
        /// <summary>
        /// Aumenta el saldo de la cuenta
        /// </summary>
        /// <param name="BA"></param>
        /// <param name="quantity"></param>
        public int IncreaseBalance(BankAccount BA, int quantity)    {
            BA.Balance += quantity;
            return BA.Balance;
        }
    }
}
