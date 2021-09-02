using Banco_2Septiembre.Interfaces;
using Banco_2Septiembre.Modelo;
using Banco_2Septiembre.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Servicios {
    class ClientService : User {
        public bool Loan() {
            throw new NotImplementedException();
        }

        public bool Login() {
            throw new NotImplementedException();
        }

        public static void Register(Client client) {
            Console.WriteLine("Se ha registrado el usuario: " + client.Name + ", con el IDUsuario" + client.UserID + ", y la contraseña: " + client.Password + ".");
            if(EmailService.CheckPassword()) {
                EmailService.SendCredentials(client.Mail);
            }           
        }

        public void Register() {
            throw new NotImplementedException();
        }

        public void Register(User user) {
            throw new NotImplementedException();
        }

        public void Transference() {
            throw new NotImplementedException();
        }
    }
}
