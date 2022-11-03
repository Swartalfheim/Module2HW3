namespace Module2HW3
{
    public class Tomatoes : IVegetables
    {
        private string[] _vegetable;
        public string[] Ingredient()
        {
            _vegetable = new string[4] { "3", "Tomatoes", "300", "18" };
            return _vegetable;
        }
    }
}
