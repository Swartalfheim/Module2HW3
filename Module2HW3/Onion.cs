namespace Module2HW3
{
    public class Onion : IVegetables
    {
        private string[] _vegetable;
        public string[] Ingredient()
        {
            _vegetable = new string[4] { "2", "Onion", "20", "40" };
            return _vegetable;
        }
    }
}
