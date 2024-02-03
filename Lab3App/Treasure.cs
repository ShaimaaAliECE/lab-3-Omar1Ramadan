using System;
using System.Collections.Generic;

namespace Lab3App
{
	internal abstract class Treasure : Collectable
	{
		public int Score { get; private set; }

		public Treasure(string value, int score) : base(value)
		{
			Score = score;
		}

        public override void AddMe(List<Collectable> list)
        {
			list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            UpdateTotalScore();

        }

		public void UpdateTotalScore()
		{
			Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
    }
}

