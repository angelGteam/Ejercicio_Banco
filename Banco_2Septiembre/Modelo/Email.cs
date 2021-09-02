using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class Email {
        public String Mail { get => Mail; set => Mail = value; }
        public String Password { get => Password; set => Password = value; }
        public Email(string mail, string password) {
            Mail = mail;
            Password = password;
        }
    }
}
