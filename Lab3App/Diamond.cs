using System;
namespace Lab3App
{
	internal class Diamond : Treasure
	{
		

		public Diamond(string value, int score) : base(value,score)
		{
			
			
		}

		public override void Display()
		{
            Console.WriteLine($"Diamond {Description} is displayed!");
        }
	}
}

