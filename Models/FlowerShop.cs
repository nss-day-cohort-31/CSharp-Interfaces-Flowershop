using System.Collections.Generic;
using System.Linq;

namespace MyFlowerShop
{
    public class FlowerShop
    {
        public List<Rose> Roses { get; set; }
        public List<Tulip> Tulips { get; set; }
        public List<SunFlower> SunFlowers { get; set; }
        public List<Lily> Lilies { get; set; }

        public List<IColorfulFlower> MakeMothersDayBouquet() {
            return new List<IColorfulFlower> {
                new Rose() {Color = "Pink", Price = 10.50},
                new Rose() {Color = "White", Price = 10.50},
                new Lily() {Color = "White", Price = 8.25},
                new Lily() {Color = "Orange", Price = 8.25}
            };
        }

        public List<IStemLengthFlower> MakeFathersDayBouquet() {
            return new List<IStemLengthFlower>{
                new Rose() {StemLength = 2.1, Price = 10.50},
                new SunFlower() {StemLength = 4.5, Price = 2.00},
                new SunFlower()  { StemLength = 2.1, Price = 2.00}
            };
        }

        public List<IPickable> MakeBouquet() {
            return new List<IPickable> {
                new Rose() {StemLength = 2.1, Price = 10.50},
                new SunFlower() {StemLength = 4.5, Price = 2.00},
                new SunFlower()  { StemLength = 2.1, Price = 2.00},
                new Rose() {Color = "Pink", Price = 10.50},
                new Rose() {Color = "White", Price = 10.50},
                new Lily() {Color = "White", Price = 8.25},
                new Lily() {Color = "Orange", Price = 8.25}
            };
        }
    }
}