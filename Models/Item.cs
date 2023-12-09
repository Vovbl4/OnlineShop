using System.ComponentModel;

namespace MyWebSiteMVC.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string FullText { get; set; }
        public string Image { get; set; }
        public int CategoryID { get; set; }//p/u a face referinta la alt tabel din SQL
        public Category Category { get; set; }

        public Item()
        {
        }

        public Item(string name, int price, string description, string fullText, string image, int categoryID)
        {
            Name = name;
            Price = price;
            Description = description;
            FullText = fullText;
            Image = image;
            CategoryID = categoryID;
        }
    }
}
