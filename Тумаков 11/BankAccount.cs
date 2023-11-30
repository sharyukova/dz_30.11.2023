using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Тумаков_11
{
    internal class BankAccount
    {
        
        internal BankAccount(uint AccountID)
        {
            accountID = AccountID;
            

        }

        public uint accountID { get; private set; }
        
    }
  
}
