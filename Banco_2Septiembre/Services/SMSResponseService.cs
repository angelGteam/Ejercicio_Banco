using Banco_2Septiembre.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Services {
    class SMSResponseService {
        public void SendMessage(int cuantia, SMSResponse SmsResponse1, SMSResponse SmsResponse2) {
            Console.WriteLine("El usuario con el número de cuenta: " + SmsResponse1.Number + ", le ha realizado una transferencia de: " + cuantia + "€, a la cuenta de: " + SmsResponse2.Number);
        }
    }
}
