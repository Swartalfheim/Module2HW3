namespace Module2HW3
{
    public class PrintInfo : MakeSalad
    {
        private VegetablesTable _print;
        private Calories _calories;
        public void PrintTable()
        {
            _print = new VegetablesTable();
            int height = _print.Table().GetLength(0);
            int width = _print.Table().GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(_print.Table()[i, j] + "; ");
                }

                Console.WriteLine();
            }
        }

        public void PrintMakeSalad()
        {
            string[,] make = new string[6, 4];
            int height = _print.Table().GetLength(0);
            int width = _print.Table().GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    make[i, j] = _print.Table()[i, j];
                }
            }

            Make(make);
        }

        public void TableInformation()
        {
            Console.WriteLine(" The table below contains information about products for making salad in the appropriate sequence:\n " +
                "product number, product name, weight, number of calories (100 grams)\n");
        }

        public void PrintFind()
        {
            Find.FindByParameter(_print.Table());
        }
    }
}
