using System;

namespace UsingInterfaces
{
    public class VenusBankAccount : IBankAccount
    {
        private decimal _balance;

        public decimal Balance => _balance;

        public void PayIn(decimal amount) => _balance += amount;

        public bool Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Withdrawal attempt failed.");
                return false;
            }
        }

        public override string ToString() =>
            $"Venus Bank: Balance = {_balance,6:C}";
    }
}
