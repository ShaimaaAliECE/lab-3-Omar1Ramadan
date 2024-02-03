using System;
namespace Lab3App
{
   internal class MagicWand : Tool
	{
		public MagicWand(string value) : base(value)
        { 
		}

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed!");
        }

        public override void doAction()
        {
            Console.WriteLine("MagicWand is used!");
        }
    }
}

