using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Services {
    class EmailService {
        public static void SendCredentials(Email email) {
            Console.WriteLine("Se ha enviado el correo a: " + email.Mail + " satisfactoriamente.");
        }
        public static Boolean CheckPassword() {
            return true;
        }
    }
}
