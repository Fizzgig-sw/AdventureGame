using System;
using System.Collections.Generic;

namespace AdventureGame
{
	public abstract class Mob
	{
		public Tuple<int,int>[] stats;
		public Tuple<Item, int>[] Drops;
		public Mob()
		{
			stats = new Tuple<int, int> [Enum.GetNames(typeof(Stats)).Length];
			for (int i = 0; i < stats.Length; i++) { stats[i] = new Tuple<int, int>(1,1); }

		}
		public virtual string Name() { return ""; }
		public virtual List<Item> Kill()
		{
			Random Random = new Random();
			List<Item> Result = new List<Item>();
			foreach (Tuple<Item, int> d in Drops)
			{
				int chance = Random.Next(100);
				if (chance <= d.Item2) { Result.Add(d.Item1); }
			}
			return Result;
		}
	}
	public class Goblin : Mob
	{
		public override string Name() { return "Goblin"; }
		public Goblin() : base()
		{
			stats[(int)Stats.STR] = new Tuple<int, int>(1, 3);
			stats[(int)Stats.CON] = new Tuple<int, int>(1, 3);
			stats[(int)Stats.DEX] = new Tuple<int, int>(1, 3);

			Drops = new Tuple<Item, int>[]
			{
				new Tuple<Item, int>(new Dagger(),25),
				new Tuple<Item, int>(new Coin(15),50)
			};
		}
	}
	public class Zombie : Mob
	{
		public override string Name() { return "Zombie"; }
		public Zombie() : base()
		{
			stats[(int)Stats.STR] = new Tuple<int, int>(1, 3);
			stats[(int)Stats.CON] = new Tuple<int, int>(1, 3);

			Drops = new Tuple<Item, int>[]
			{
				new Tuple<Item, int>(new Apple(2),50),
				new Tuple<Item, int>(new Coin(5),50)
			};
		}
	}
	public class Slime : Mob
	{
		public override string Name() { return "Slime"; }
		public Slime() : base()
		{
			Drops = new Tuple<Item, int>[]
			{
				new Tuple<Item, int>(new Apple(1),100),
				new Tuple<Item, int>(new Coin(5),50)
			};
		}
	}
}
