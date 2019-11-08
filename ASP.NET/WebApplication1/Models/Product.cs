using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";

        //? betekent nullable
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }

        public Product(bool stock = true)
        {
            InStock = stock;
        }

        //maak een static method om hier ter plaatste
        //een aantal 'Producten' aan te maken en
        //op te vragen...
        //Dit kan later van elders komen...(database ofzo)
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak",
                Category = "Water Craft",
                Price = 275M //M wijst op decimal
            };
            Product lifejacket = new Product(false)
            {
                Name = "LifeJacket",
                Price = 48.94M
            };

            kayak.Related = lifejacket;

            return new Product[] { kayak, lifejacket, null };
        }
    }
}
