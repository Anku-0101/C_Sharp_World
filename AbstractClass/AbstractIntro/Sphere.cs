using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractIntro
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }


        public override double Volume()
        {
            double vol = (4 / 3) * Math.PI * Math.Pow(Radius, 3);
            return vol;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Radius of Sphere is {0}",Radius);
        }
    }
}
