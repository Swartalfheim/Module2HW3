using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Starter
    {
        public void Start()
        {
            Recipe recipe = new Recipe();
            recipe.GreekSaladRecipe();
            PrintInfo printInfo = new PrintInfo();
            printInfo.TableInformation();
            printInfo.Info();
            Console.WriteLine("/////////////////////////////////////////////////////");
            CountCalories countCalories = new CountCalories();
            countCalories.Calories();
            Console.WriteLine("/////////////////////////////////////////////////////");
            Search.SearchByParams("search");
            Console.ReadKey();
            Console.Clear();
            Sort sort = new Sort();
            sort.SortByParameter();
        }
    }
}
