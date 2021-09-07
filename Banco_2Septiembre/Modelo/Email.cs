using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class Email {
        #region "Variables
        public String Mail;
        public String Password;
        #endregion
        #region "constructor"
        public Email(string mail, string password) {
            Mail = mail;
            Password = password;
        }
        #endregion
    }
}
