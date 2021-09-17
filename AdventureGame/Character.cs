using System;

namespace AdventureGame
{
	public enum Stats { STR, INT, CON, DEX, AGI, LUK }
	
	public partial class Character
	{
		public enum Gender { Male, Female }
		public enum AdventureClass { Warrior, Mage, Archer, Thief }
		public int Bonus = 1;
		public Mob Mob;

		//Character Properties
		public Gender gender;
		public string name;
		public AdventureClass type;
		public int[] stats;

		//NPC
		public Character(int seed = 0)
		{
			Random Random = seed == 0 ? new Random() : new Random(seed);
			//name and gender
			gender = Random.Next(2) > 0 ? Gender.Male : Gender.Female;
			name = Names[(int)gender][Random.Next(Names[(int)gender].Length)];

			//class
			type = (AdventureClass)Random.Next(Enum.GetNames(typeof(AdventureClass)).Length);

			//stats
			stats = new int[Enum.GetNames(typeof(Stats)).Length];
			//initial Value
			for (int i = 0; i < stats.Length; i++) { stats[i] = Random.Next(1, 6); }
			//bonus and penalty
			switch (type)
			{
				case AdventureClass.Warrior: stats[(int)Stats.STR] += Bonus; stats[(int)Stats.INT] -= Bonus; break;
				case AdventureClass.Mage: stats[(int)Stats.INT] += Bonus; stats[(int)Stats.STR] -= Bonus; break;
				case AdventureClass.Archer: stats[(int)Stats.DEX] += Bonus; break;
				case AdventureClass.Thief: stats[(int)Stats.AGI] += Bonus; stats[(int)Stats.LUK] += Bonus; break;
			}
			//normalize values from 1-5
			for (int i = 0; i < stats.Length; i++) { stats[i] = stats[i] < 1 ? 1 : stats[i] > 5 ? 5 : stats[i]; }
		}

		//Mob
		public Character(Mob Mob, int seed = 0)
		{
			this.Mob = Mob;
			Random Random = seed == 0 ? new Random() : new Random(seed);
			//Name
			name = Mob.Name();
			//Stats
			stats = new int[Enum.GetNames(typeof(Stats)).Length];
			for (int i = 0; i < Enum.GetNames(typeof(Stats)).Length; i++)
			{
				stats[i] = Random.Next(Mob.stats[i].Item1, Mob.stats[i].Item2 + 1);
			}
		}
		public int Sum() { int result = 0; foreach (int i in stats) { result += i; } return result; }
	}
}
