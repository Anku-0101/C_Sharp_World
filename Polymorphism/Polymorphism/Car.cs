using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        // Every Car has a CarInfo
        // Has a relationship 
        protected CarInfo mycar = new CarInfo();

        public void SetCarIDInfo(int idNum, string owner)
        {
            mycar.ID = idNum;
            mycar.owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("Car ID is {0} and owned by {1}", mycar.ID, mycar.owner);
        }
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP of the car is {0} and Color of the car is {1}", HP, Color);
        }

        public void Repair()
        {
            Console.WriteLine("The car was repaired");
        }
    }
}
