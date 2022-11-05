using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Sort : VegetablesTable
    {
        public void SortByParameter()
        {
            int height = Table().GetLength(0);
            int width = Table().GetLength(1);
            Console.WriteLine("You must enter the number corresponding to the sort parameter\n");
            Console.WriteLine("choose by what parameter you want to sort the list of ingredients (1, 2):\n" +
                "1) by number, 2) by weight\n");
            string sort = Console.ReadLine();
            Console.Clear();
            switch (sort)
            {
                case "1":
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            Console.Write(Table()[i, j] + "; ");
                        }

                        Console.WriteLine();
                    }

                    break;
                case "2":
                    int[] a = new int[6]; // to record weight
                    string[] b = new string[6]; // to write a name
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (j == 2)
                            {
                                a[i] = int.Parse(Table()[i, j]);
                            }
                        }
                    }

                    a = a.OrderBy(i => i).ToArray();
                    for (int i = 0; i < a.Length; i++)
                    {
                        for (int g = 0; g < height; g++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                if (Convert.ToString(a[i]) == Table()[g, j])
                                {
                                    b[i] = Table()[g, 1];
                                }
                            }
                        }
                    }

                    for (int i = 0; i < b.Length; i++)
                    {
                        Console.WriteLine($"{b[i]} = {a[i]} gram");
                    }

                    break;
            }
        }
    }
}
