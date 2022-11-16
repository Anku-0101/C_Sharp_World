using System;
namespace ExtensionMethods
{
    public class Animal
    {
        private string color;
        private int numOfLegs;
        
        public string GetColor()
        {
            return color;
        }

        public int  GetNumberOfLegs()
        {
            return numOfLegs;
        }

        public void SetColor(string Color)
        {
            this.color = Color;
        }

        public void SetNumberOfLegs(int NumberOFlegs)
        {
            this.numOfLegs = NumberOFlegs;
        }
    }

}

