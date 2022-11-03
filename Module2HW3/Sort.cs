namespace Module2HW3
{
    internal class Sort : AllInformation
    {
        public void SortByParameter()
        {
            Console.WriteLine("You must enter the number corresponding to the sort parameter\n");
            Console.WriteLine("choose by what parameter you want to sort the list of ingredients (1, 2, 3):\n" +
                "1) by number, 2) by weight, 3) by the number of kilocalories\n");
            string sort = Console.ReadLine();
            switch (sort)
            {
                case "1":
                    foreach (IVegetables v in All())
                    {
                        for (int i = 0; i < v.Ingredient().Length; i++)
                        {
                            Console.Write(v.Ingredient()[i] + ";  ");
                        }

                        Console.WriteLine();
                    }

                    break;
                case "2":
                    foreach (IVegetables v in AllWeight())
                    {
                        for (int i = 0; i < v.Ingredient().Length; i++)
                        {
                            Console.Write(v.Ingredient()[i] + ";  ");
                        }

                        Console.WriteLine();
                    }

                    break;
                case "3":
                    foreach (IVegetables v in AllKalories())
                    {
                        for (int i = 0; i < v.Ingredient().Length; i++)
                        {
                            Console.Write(v.Ingredient()[i] + ";  ");
                        }

                        Console.WriteLine();
                    }

                    break;
            }
        }
    }
}
