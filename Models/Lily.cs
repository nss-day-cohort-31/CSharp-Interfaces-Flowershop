using System;

namespace MyFlowerShop
{
    public class Lily : Flower, IColorfulFlower
    {
        public string Color { get; set; }

        public void Pick() {
            Console.WriteLine("Picking a Lily");
        }

        public override string ToString()
        {
            return $"A {Color} lily is {Price:c}";
        }
    }
}