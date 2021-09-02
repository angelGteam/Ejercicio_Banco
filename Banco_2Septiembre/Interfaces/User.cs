using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Interfaces {
    interface User {
        void Register(User user);
        Boolean Login();
        void Transference();
        Boolean Loan(); //Prestamo

    } 

}
