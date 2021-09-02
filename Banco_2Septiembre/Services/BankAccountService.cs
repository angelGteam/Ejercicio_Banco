using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class BankAccountService {
        void ReduceBalance(BankAccount BA, int quantity) {
            BA.Balance -= quantity;
        }
        void IncreseBalance(BankAccount BA, int quantity) {
            BA.Balance += quantity;
        }
    }
}
