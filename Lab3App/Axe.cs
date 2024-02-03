using System;
namespace Lab3App
{
	internal class Axe : Tool
	{
        public Axe(string value) : base(value)
        {
            
        } 
        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed!");
        }

        public override void doAction()
        {
            Console.WriteLine("Axe is used!");
        }
    }
}

