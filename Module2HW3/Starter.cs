namespace Module2HW3
{
    public class Starter
    {
        public void Start()
        {
            Calories calories = new Calories();
            PrintInfo printInfo = new PrintInfo();
            printInfo.TableInformation();
            printInfo.PrintTable();
            printInfo.PrintMakeSalad();
            calories.RezCalories();
            printInfo.PrintFind();
            Sort sort = new Sort();
            sort.SortByParameter();
        }
    }
}
