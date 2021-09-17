using System.Collections.Generic;

namespace AdventureGame
{
	public partial class Character
	{
		public static List<string[]> Names = new List<string[]>() {
			#region Male Names
			new string[]{ "Bob", "Joe" },
			#endregion

			#region Female Names
			new string[]{ "Sarah", "Jane" }
			#endregion
		};
	}
}
