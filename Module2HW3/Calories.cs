using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Calories : VegetablesTable
    {
        public void RezCalories()
        {
            int c = 0;
            int allc = 0;
            int height = Table().GetLength(0);
            int width = Table().GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 3)
                    {
                        c = int.Parse(Table()[i, 3]) * int.Parse(Table()[i, 2]) / 100;
                        Console.WriteLine($"\ncalories {Table()[i, 1]}: {c}");
                        allc = allc + c;
                    }
                }
            }

            Console.WriteLine($"\nTotal calories: {allc}");
        }
    }
}
