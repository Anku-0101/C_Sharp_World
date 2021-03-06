﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //Audi Is a CAR
    //Is a relationship
    class Audi : Car
    {
        protected string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        public void Brand()
        {
            Console.WriteLine("Brand is {0}", this.GetType());
        }

        public new void ShowDetails()
        {
            Console.WriteLine("Car is Audi of Model {0} and Color {1}", Model, HP);
        }

        public new void Repair()
        {
            Console.WriteLine("The car {0} is Repaired", Model);
        }
    }
}
