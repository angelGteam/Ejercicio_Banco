using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Interfaces {
    interface IUserable {
        string UserID { get; }
        string Name { get; }
        string Password { get; }
        Email Mail { get; }
        int PhoneNumber { get; }
        BankAccount BankAccount { get; }
        int permission { get; }

        void Loan(IUserable userable);
        void Login(IUserable userable);
        void Register(IUserable userable);
        void Transference(IUserable userable1, IUserable userable2, int quantity);
        bool CheckPermissions(IUserable userable);
    } 
}
