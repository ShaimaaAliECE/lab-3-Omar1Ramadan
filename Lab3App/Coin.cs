using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal class Coin : Treasure
	{
		public int Value { get; set; }

        public Coin(string coin, int score, int value) : base (coin, score)
        {
           this.Value = value;
        }

		public void UpdateTotalValue()
		{
            Board.TotalValue += Value;
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
		}

        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed!");
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
    }
}

