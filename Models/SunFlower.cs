using System;

namespace MyFlowerShop
{
    public class SunFlower : Flower, IStemLengthFlower
    {
        public double StemLength { get; set; }

        public void Pick() {
            Console.WriteLine("Picking a Sunflower");
        }

        public override string ToString() {
            return $"A sunflower is {Price:c}";
        }
    }
}