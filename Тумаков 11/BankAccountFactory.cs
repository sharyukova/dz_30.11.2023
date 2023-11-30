using System;
using System.Collections.Generic;
using System.Collections;

namespace Тумаков_11
{
    public class BankAccountFactory
    {
        
        internal AccountCreating createAccount()
        {
            return new AccountCreating();
        }

        internal ClosingAccount closeAccount()
        {
            return new ClosingAccount();
        }
        
    }
}
