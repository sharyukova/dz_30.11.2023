using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_11
{
    internal class User
    {
        
        private AccountCreating Creating;
        private ClosingAccount Closing;
        public User(BankAccountFactory factory) 
        { 
            Creating = factory.createAccount();
            Closing = factory.closeAccount();
        }
        public void Create()
        {
            Creating.CreateAccount();
        }
        public void Close()
        {
            //Closing.CloseAccount();
        }
        
    }
}
