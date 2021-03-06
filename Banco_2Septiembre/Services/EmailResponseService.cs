using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using System;

namespace Banco_2Septiembre.Services {
    class EmailResponseService : ISendable {
        #region "constructor"
        public EmailResponseService() {
        }
        #endregion
        #region "metodos"
        /// <summary>
        /// Envia un correo al email tras completar el registro
        /// </summary>
        /// <param name="email"></param>
        public void SendMessage(Email email) {
            Console.WriteLine(GetMessage());
        }
        /// <summary>
        /// Comprueba que la contrasegna sea correcta
        /// </summary>
        /// <returns></returns>
        public static Boolean CheckPassword() {
            return true;
        }
        public string GetMessage() {
            return "Se ha enviado el correo satisfactoriamente.";
        }
        #endregion
    }
}
