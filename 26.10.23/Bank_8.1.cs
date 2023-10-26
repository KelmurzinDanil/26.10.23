using System;

namespace _26._10._23
{
    internal class Bank_8
    {
        private uint accountNumber;
        private decimal balance;
        private decimal balanceChildren;
        public decimal Balance
        {
            get { return balance; }
        }
        public decimal BalanceChildren
        {
            get { return balanceChildren; }
        }
        public uint AccountNumber
        {
            get { return accountNumber; }
        }

        public Bank_8(uint accountNumber, decimal Balance, decimal BalanceChildren)
        {
            this.accountNumber = accountNumber;
            this.balance = Balance;
            this.balanceChildren = BalanceChildren;
        }
        public decimal Deposit(decimal amount)
        {
            balance += amount;
            return balance;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Вы не можете столько снять");
            }
            else
            {
                balance -= amount;
            }
            return balance;
        }
        public decimal Transfer(decimal amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Вы не можете столько перевести");
            }
            else
            {
                balanceChildren += amount;
                this.Withdraw(amount);
            }
            return balanceChildren;

        }
        public override string ToString() => $"AccountNumber - {AccountNumber}, Balans - {balance}, BalanceChildren - {balanceChildren}";
    }
}
