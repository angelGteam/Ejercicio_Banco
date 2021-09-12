using Banco_2Septiembre.Modelo;

namespace Banco_2Septiembre.Interfaces {
    abstract class User {
        #region "Variables"
        public string UserID;
        public string Name;
        public string Password;
        public Email Mail;
        public int PhoneNumber;
        public BankAccount BankAccount;
        public int Permission;
        #endregion
    }
}
