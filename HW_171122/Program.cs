using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_171122
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunItem rItem = new RunItem();
            rItem.runTwoItems();
            rItem.runTenItems();
            rItem.runHundredItems();

            Console.ReadLine();

        }
    }
}
