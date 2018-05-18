using System;

namespace Prototype
{
    class Color : ICloneable
    {
        private int red;
        private int green;
        private int yellow;
        public Color(int red,int green,int yellow)
        {
            this.red = red;
            this.green = green;
            this.yellow = yellow;
        }
        public object Clone()
        {
            Console.WriteLine($"Cloning color RGB: {red},{green},{yellow}");
            return this.MemberwiseClone() as Color;
        }
    }
}
