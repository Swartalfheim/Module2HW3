using System.Drawing;

namespace Module2HW3
{
    public static class Find
    {
        public static void FindByParameter(this string[,] mass)
        {
            Console.WriteLine("\n Select by what parameter you want to search for ingredients:\n" +
               " 1) weight, 2) name (Capitalized), 3) kilocalories;\n" +
               " to select an item, you must select the number corresponding to the parameter");
            string search = Console.ReadLine();
            int height = mass.GetLength(0);
            int width = mass.GetLength(1);
            switch (search)
            {
                case "1":
                    Console.WriteLine("Enter weight");
                    string weight = Console.ReadLine();
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (mass[i, 2] == weight)
                            {
                                Console.Write(mass[i, j] + ";  ");
                            }
                        }

                        Console.WriteLine();
                    }

                    break;
                case "2":
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (mass[i, 1] == name)
                            {
                                Console.Write(mass[i, j] + ";  ");
                            }
                        }

                        Console.WriteLine();
                    }

                    break;
                case "3":
                    Console.WriteLine("Enter kilocalories");
                    string calories = Console.ReadLine();
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < width; j++)
                        {
                            if (mass[i, 3] == calories)
                            {
                                Console.Write(mass[i, j] + ";  ");
                            }
                        }

                        Console.WriteLine();
                    }

                    break;
            }
        }
    }
}
