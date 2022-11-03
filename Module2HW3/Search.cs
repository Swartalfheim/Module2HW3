using System.Net.NetworkInformation;

namespace Module2HW3
{
    public static class Search
    {
        public static void SearchByParams(this string str)
        {
            AllInformation allInformation = new AllInformation();
            Console.WriteLine("\n Select by what parameter you want to search for ingredients:\n" +
               " 1) weight, 2) name (Capitalized), 3) kilocalories;\n" +
               " to select an item, you must select the number corresponding to the parameter");
            string search = Console.ReadLine();
            switch (search)
            {
                case "1":
                    Console.WriteLine("Enter weight");
                    string weight = Console.ReadLine();
                    foreach (IVegetables v in allInformation.All())
                    {
                        for (int i = 0; i < v.Ingredient().Length; i++)
                        {
                            if (v.Ingredient()[2] == weight)
                            {
                                Console.Write(v.Ingredient()[i] + ";  ");
                            }
                        }

                        Console.WriteLine();
                    }

                    break;
                case "2":
                    Console.WriteLine("Enter name");
                    string name = Console.ReadLine();
                    foreach (IVegetables v in allInformation.All())
                    {
                        for (int i = 0; i < v.Ingredient().Length; i++)
                        {
                            if (v.Ingredient()[1] == name)
                            {
                                Console.Write(v.Ingredient()[i] + ";  ");
                            }
                        }

                        Console.WriteLine();
                    }

                    break;
                case "3":
                    Console.WriteLine("Enter kilocalories");
                    string kilocalories = Console.ReadLine();
                    foreach (IVegetables v in allInformation.All())
                    {
                        for (int i = 0; i < v.Ingredient().Length; i++)
                        {
                            if (v.Ingredient()[3] == kilocalories)
                            {
                                Console.Write(v.Ingredient()[i] + ";  ");
                            }
                        }

                        Console.WriteLine();
                    }

                    break;
            }

            Console.WriteLine("press any key to continue");
        }
    }
}
