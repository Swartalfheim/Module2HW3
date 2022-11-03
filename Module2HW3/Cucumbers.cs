namespace Module2HW3
{
    public class Cucumbers : IVegetables
    {
        private string[] _vegetable;
        public string[] Ingredient()
        {
            _vegetable = new string[4] { "4", "Cucumbers", "50", "20" };
            return _vegetable;
        }
    }
}
