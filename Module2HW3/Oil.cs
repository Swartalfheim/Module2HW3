namespace Module2HW3
{
    public class Oil : IVegetables
    {
        private string[] _vegetable;
        public string[] Ingredient()
        {
            _vegetable = new string[4] { "6", "Oil", "15", "884" };
            return _vegetable;
        }
    }
}
