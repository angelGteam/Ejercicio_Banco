using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_Ejercicio.Interfaces {
    interface Iuserable {
        public void Register(User user, EmailResponseService emailResponseService);
        public void Transference(User User1, User User2, int Quantity, SMSResponseService smsResponseService);
        public bool CheckPermissions(User user);
    }
}
