using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal abstract class Collectable : Displayable
	{
		public string Description { get; set; }
		public CollectionBoard Board { get; set; }

		public Collectable(string value)
		{
			this.Description = value;
		}


		public virtual void AddMe(List<Collectable> list)
		{
			
		}
		public abstract void Display();
    }
}

