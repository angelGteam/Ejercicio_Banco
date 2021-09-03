using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Interfaces {
    interface User {
        void Register(User user);
        void Login(User user);
        void Transference(User user);
        void Loan(User user); //Prestamo
        Boolean CheckPermissions(User user);
    } 

}
