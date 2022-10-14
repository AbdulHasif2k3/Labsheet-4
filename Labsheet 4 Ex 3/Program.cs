using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_4_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            BankAccount acc1 = new BankAccount("45682012", "Troy Shilton", 100);
            BankAccount acc2 =new BankAccount("75587891", "Eoghan Kearns", 200);

            Console.WriteLine(acc1.GetAccountDetails());
            Console.WriteLine(acc2.GetAccountDetails());

            Console.WriteLine("Adding €250 to account 1");
            acc1.Deposit(1250);
            Console.WriteLine(acc1.GetAccountDetails());

            Console.WriteLine("Withdrawing €25 from account 2");
            acc2.Withdraw(25);
            Console.WriteLine(acc2.GetAccountDetails());

            Console.ReadLine();

        }
    }
}
