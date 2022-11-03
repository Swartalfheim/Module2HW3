namespace Module2HW3
{
    internal class AllInformation
    {
        public IVegetables[] All()
        {
            IVegetables[] all = { new Pepper(), new Onion(), new Tomatoes(), new Cucumbers(), new Olives(), new Oil() };
            return all;
        }

        public IVegetables[] AllWeight()
        {
            IVegetables[] all = { new Tomatoes(), new Pepper(), new Olives(), new Cucumbers(), new Onion(), new Oil() };
            return all;
        }

        public IVegetables[] AllKalories()
        {
            IVegetables[] all = { new Oil(), new Olives(), new Onion(), new Cucumbers(), new Tomatoes(), new Pepper(),};
            return all;
        }
    }
}
