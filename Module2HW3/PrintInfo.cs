using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class PrintInfo
    {
        private AllInformation _printInfo = new AllInformation();
        public void Info()
        {
            foreach (IVegetables v in _printInfo.All())
            {
                for (int i = 0; i < v.Ingredient().Length; i++)
                {
                    Console.Write(v.Ingredient()[i] + ";  ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public void TableInformation()
        {
            Console.WriteLine("Parameters in the table are arranged in the same order as in the description.");
            Console.WriteLine("number;  title;  the weight;  kilocalories per 100 grams:");
        }
    }
}
