using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_4_Ex_5
{
    internal class CashRegister
    {
        public static double totalMoneyAllCrs { get; set; }
        public static int totalItemsAllCrs { get; set; }

        public int NumberofItems { get; private set; }
        public double Total { get;private set; }

        public void AddItem(double itemPrice)
        {
            Total += itemPrice;
            NumberofItems++;

            totalItemsAllCrs++;
            totalMoneyAllCrs += itemPrice;
        }
    }
}
