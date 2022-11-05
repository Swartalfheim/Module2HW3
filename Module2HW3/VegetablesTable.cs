namespace Module2HW3
{
    public class VegetablesTable : Vegetables
    {
        private string[,] _vegetables;
        public override string[,] Table()
        {
            _vegetables = new string[6, 4]
            {
                { "1", "Pepper", "200", "15" },
                { "2", "Onion", "20", "40" },
                { "3", "Tomatoes", "30", "18" },
                { "4", "Cucumbers", "50", "10" },
                { "5", "Olives", "100", "115" },
                { "6", "Oil", "15", "884" }
            };
            return _vegetables;
        }
    }
}
