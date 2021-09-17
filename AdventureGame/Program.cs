using System;
using System.Collections.Generic;

namespace AdventureGame
{
	class Program
	{
		static void Main(string[] args)
		{
			int Treasury = 0;
			Random Random = new Random();
			while (true)
			{
				Console.Clear();
				Console.WriteLine($"Town Treasury: {Treasury}\n");
				
				Character Character = new Character();
				Console.WriteLine(Character.name);
				Console.WriteLine($"{Character.type}\n");
				for (int i = 0; i < Enum.GetNames(typeof(Stats)).Length; i++) {
					Console.WriteLine($"{(Stats)i}: {Character.stats[i]}");	
				}

				Console.WriteLine($"\nSum: {Character.Sum()}\n");

				Mob nmob = new Goblin();
				switch (Random.Next(3))
				{
					case 0: nmob = new Goblin(); break;
					case 1: nmob = new Zombie(); break;
					case 2: nmob = new Slime(); break;
				}
				Character Creature = new Character(nmob);
				Console.WriteLine(Creature.name);
				for (int i = 0; i < Enum.GetNames(typeof(Stats)).Length; i++)
				{
					Console.WriteLine($"{(Stats)i}: {Creature.stats[i]}");
				}
				
				Console.WriteLine($"\nSum: {Creature.Sum()}\n");
				
				ConsoleKeyInfo input = Console.ReadKey(true);
				if (input.Key == ConsoleKey.Escape) { break; }
				if (input.Key == ConsoleKey.K) {
					Console.WriteLine("\nItem Drops:");
					Console.WriteLine("===========");
					foreach (Item i in Creature.Mob.Kill())
					{
						if (i.Type() == ItemType.Coin) { Console.WriteLine($"{i.Name()} x{i.value}"); Treasury += i.value; }
						else if (i.Type() == ItemType.Health) { Console.WriteLine($"{i.Name()} x{i.value}"); }
						else { Console.WriteLine($"{i.Name()}"); }
					}
					Console.ReadKey(true);
				}
			}
		}
	}
}
