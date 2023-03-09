using System;
namespace RpgLogicProject
{
    public class Item
    {
        public string Name { get; set; }
        public int Weigth { get; set; }

        public int Cost { get; set; }

        public Item(string name, int weigth, int cost)
        {
            Name = name;
            Weigth = weigth;
            Cost = cost;
        }
    }
}
