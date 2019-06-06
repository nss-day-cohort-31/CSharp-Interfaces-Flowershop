using System;

namespace MyFlowerShop
{
    public class Tulip : Flower, IColorfulFlower
    {
        public string Color { get; set; }

        public void Pick() {
            Console.WriteLine("Picking a Tulip");
        }

        public override string ToString() {
            return $"A {Color} tulip is {Price:c}";
        }
    }
}