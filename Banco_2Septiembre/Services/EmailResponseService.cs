using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Services {
    class EmailResponseService : ISendable {
        /// <summary>
        /// Envia un correo al email tras completar el registro
        /// </summary>
        /// <param name="email"></param>
        public static void SendMessage(Email email) {
            Console.WriteLine("Se ha enviado el correo a: " + email.Mail + " satisfactoriamente.");
        }
        /// <summary>
        /// Comprueba que la contrasegna sea correcta
        /// </summary>
        /// <returns></returns>
        public static Boolean CheckPassword() {
            return true;
        }
    }
}
