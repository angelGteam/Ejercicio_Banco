using Banco_2Septiembre.Interfaces;

namespace Banco_2Septiembre.Modelo {
    class Employee : User {
        #region "Constructor"
        // En caso de que User tuviese un constructor, usariamos :base(param)
        public Employee(string userID, string name, string password, Email mail, int phoneNumber, BankAccount bankAccount) {
            UserID = userID;
            Name = name;
            Password = password;
            Mail = mail;
            PhoneNumber = phoneNumber;
            BankAccount = bankAccount;
            Permission = 1;
        }
        #endregion
    }
}
