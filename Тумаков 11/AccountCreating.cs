using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_11
{
    internal class AccountCreating 
    {
        
        private Hashtable accounts = new Hashtable();
        private uint nextAccountNumber = 223921;
        public uint CreateAccount()
        {
            BankAccount account = new BankAccount(nextAccountNumber);
            accounts.Add(nextAccountNumber, account);
            nextAccountNumber++;
            return account.accountID;
        }
        
    }
}
