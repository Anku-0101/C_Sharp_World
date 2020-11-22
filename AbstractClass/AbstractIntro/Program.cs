using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Cube(5), new Sphere(7) };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has volume {1}",shape.Name,shape.Volume());

                //is and as keywords

                Cube ice = shape as Cube;

                if(ice == null)
                {
                    Console.WriteLine("Not a cube");
                }
                if(ice is Cube)
                {
                    Console.WriteLine("Is a cube");
                }
            }
            Console.ReadKey();
            //Shape sphere = new Sphere(3);
            //sphere.GetInfo();
            //double res = sphere.Volume();
            //Console.WriteLine(res);
            //Console.ReadKey();
        }
    }
}
