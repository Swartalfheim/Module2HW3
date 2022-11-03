using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    internal class CountCalories
    {
        private AllInformation _calories = new AllInformation();
        public void Calories()
        {
            int kilocalories;
            int allkilocalories = 0;
            foreach (IVegetables v in _calories.All())
            {
                for (int i = 0; i < v.Ingredient().Length; i++)
                {
                    if (i == 3)
                    {
                        kilocalories = int.Parse(v.Ingredient()[i]) * int.Parse(v.Ingredient()[i - 1]) / 100;
                        allkilocalories = allkilocalories + kilocalories;
                        Console.WriteLine($"{v.Ingredient()[1]}, " +
                            $" {kilocalories} " +
                            $"kilocalories");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine($"In total, the dish contains: {allkilocalories}, kilocalories");
        }
    }
}
