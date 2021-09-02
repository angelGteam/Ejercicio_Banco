using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_2Septiembre.Modelo {
    class SMSResponse {
        public int Number { get => Number; set => Number = value; }
        public SMSResponse(int number) {
            Number = number;
        }
    }
}
