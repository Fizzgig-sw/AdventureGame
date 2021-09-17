using System;

namespace AdventureGame
{
	public enum ItemType { None, Weapon, Health, Armor, Coin }

	public abstract class Item
	{
		public int value = 1;
		public virtual string Name() { return ""; }
		public virtual ItemType Type() { return ItemType.None; }
		public Item(int value = 1)
		{
			Random Random = new Random();
			this.value = Random.Next(1, value);
		}
	}
	public class Dagger : Item
	{
		public override string Name() { return "Dagger"; }
		public override ItemType Type() { return ItemType.Weapon; }
	}
	public class Apple : Item
	{
		public override string Name() { return "Apple"; }
		public override ItemType Type() { return ItemType.Health; }
		public Apple(int value = 1) : base(value) { }
	}
	public class Coin : Item
	{
		public override string Name() { return "Coin"; }
		public override ItemType Type() { return ItemType.Coin; }
		public Coin(int value = 1) : base(value) { }
	}
}
