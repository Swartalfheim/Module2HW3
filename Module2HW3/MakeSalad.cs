using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class MakeSalad : IMake
    {
        public string[,] Make(string[,] make)
        {
            Console.WriteLine();
            int height = make.GetLength(0);
            int width = make.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i <= 3 && j == 1)
                    {
                        Console.Write("cut " + make[i, j] + ", ");
                    }

                    if (i > 3 && j == 1)
                    {
                        Console.Write("then add" + make[i, j] + ", ");
                    }
                }
            }

            Console.WriteLine("mix everything and the salad is ready");
            Console.WriteLine("Information on how many different ingredients are needed is in the table");
            return make;
        }
    }
}
