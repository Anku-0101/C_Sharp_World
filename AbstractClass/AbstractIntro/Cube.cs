using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractIntro
{
    class Cube : Shape
    {
        public double dimension { get; set; }
        public Cube(double dim)
        {
            Name = "Cube";
            dimension = dim;
        }

        public override double Volume()
        {
            return Math.Pow(dimension, 3);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Length/breadth/height of the cube is {0}",dimension);
        }
    }
}
