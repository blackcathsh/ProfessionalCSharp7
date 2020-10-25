using System;

namespace UsingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IBankAccount venusBankAccount = new VenusBankAccount();
            venusBankAccount.PayIn(200);
            venusBankAccount.Withdraw(100);
            Console.WriteLine($"{venusBankAccount}");
        }
    }
}
