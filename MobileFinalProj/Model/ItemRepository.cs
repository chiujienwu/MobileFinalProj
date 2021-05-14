using System;
using System.Collections.Generic;
using System.Text;

namespace MobileFinalProj.Model
{
    public static class ItemRepository
    {
        static ItemRepository()
        {
            if (Items == null)
            {
                Items = new List<Item>
                {
                     new Item
                            {
                                Id = Guid.Parse("{70822596-265D-49E3-8CCC-CD996093E601}"),
                                ItemName = "Nolan Ryan",
                                ImageName = "nolanryan.png",
                                ImageUrl = "https://i.ebayimg.com/images/g/j1YAAOSwuSZe8v9G/s-l1600.jpg",
                                Price = 2.45,
                                Quantity = 1

                            },
                            new Item
                            {
                                Id = Guid.Parse("{11DB10F5-C461-490F-A7A3-5BA5AF3A58AF}"),
                                ItemName = "Rickey Henderson",
                                ImageName = "rickeyhenderson.png",
                                ImageUrl = "https://retrosportcards.files.wordpress.com/2019/05/unknown-1.jpeg?w=764",
                                Price = 2000.00,
                                Quantity = 1

                            },
                            new Item
                            {
                                Id = Guid.Parse("{0AC44F1C-84FB-4BCC-8E1F-49FCC8F2A17C}"),
                                ItemName = "Eddie Murray",
                                ImageName = "eddiemurray.png",
                                ImageUrl = "https://www.oldsportscards.com/wp-content/uploads/2019/12/1978-Topps-36-Eddie-Murray-Rookie-Card.jpeg",
                                Price = 1550.00,
                                Quantity = 1

                            }
                };
            }
        }

        public static List<Item> Items { get; set; }

        public static void AddItem(Item item)
        {
            item.Id = Guid.NewGuid();
            item.ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg";
            Items.Add(item);
        }

    }
}
