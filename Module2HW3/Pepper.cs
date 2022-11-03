namespace Module2HW3
{
    public class Pepper : IVegetables
    {
        private string[] _vegetable;
        public string[] Ingredient()
        {
            _vegetable = new string[4] { "1", "Pepper", "200", "15" };
            return _vegetable;
        }
    }
}
