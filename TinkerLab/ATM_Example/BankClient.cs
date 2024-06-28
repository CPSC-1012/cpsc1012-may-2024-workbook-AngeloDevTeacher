using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Example
{
    internal class BankClient
    {
        // These are members (these are "fields" within a class).
        // https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/fields
        internal uint ClientNumber;
        internal string ClientName 
        { 
            get {  return _clientName; }
        }
        internal decimal ClientBalance
        {
            get { return _balance; }
        }

        private string _clientName;
        private uint _clientPin;
        private decimal _balance;

        public BankClient(uint clientNumber, string name, uint pin)
        {
            ClientNumber = clientNumber;
            _clientName = name;
            _clientPin = pin;
            _balance = 0;
        }

        public void DepositMoneyIntoAccount(decimal moneyToDeposit)
        {
            if(moneyToDeposit > 0)
            {
                _balance += moneyToDeposit;
            }
        }
        public void WithdrawMoneyFromAccount(decimal moneyToWithdraw)
        {
            if (_balance - moneyToWithdraw > 0)
            {
                _balance -= moneyToWithdraw;
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"{_balance:$#,0.00}");
        }


    }
}
