using System;
using System.Collections.Generic;
namespace Lab3App
{
	internal abstract class Tool : Collectable
	{
	
		protected Tool(string value) : base(value)
		{
		}

		public abstract void doAction();

        public override void AddMe(List<Collectable> list)
		{
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            doAction();
        }
	}
}

