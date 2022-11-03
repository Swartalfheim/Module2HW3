namespace Module2HW3
{
    public class Olives : IVegetables
    {
        private string[] _vegetable;
        public string[] Ingredient()
        {
            _vegetable = new string[4] { "5", "Olives", "100", "115" };
            return _vegetable;
        }
    }
}
