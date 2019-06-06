using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            FlowerShop shop = new FlowerShop();
            List<IColorfulFlower> mothersDay = shop.MakeMothersDayBouquet();

            foreach(IColorfulFlower flower in mothersDay) {
                Console.WriteLine(flower);
            }

            Rose aRose = new Rose() {
                HasThorns = true,
                Color = "red",
                StemLength = 8.5,
                Price = 200.00
            };

            Console.WriteLine(aRose);

            FlowerShop shop = new FlowerShop();
            if (shop.Roses == null) {
                Console.WriteLine(
                    "You didn't make a new list!"
                );
            } else {
                shop.Roses.Add(aRose);
                Console.WriteLine(shop.Roses.First());
            }
        }
    }
}
