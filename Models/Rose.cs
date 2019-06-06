using System;

namespace MyFlowerShop
{
    public class Rose : Flower, IColorfulFlower, IStemLengthFlower
    {
        public string Color { get; set; }
        public bool HasThorns { get; set; }
        public double StemLength { get; set; }

        public void Pick() {
            Console.WriteLine("Picking a Rose");
        }

        public override string ToString() {
            return $"A {Color} rose is {Price:c}";
        }
    }
}