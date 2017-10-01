namespace GREEDY.Models
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        public Item(string name = "", decimal price = 0, string category = "")
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}