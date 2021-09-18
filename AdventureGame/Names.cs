﻿using System.Collections.Generic;

namespace AdventureGame
{
	public partial class Character
	{
		public static List<string[]> Names = new List<string[]>() {
			#region Male Names
			new string[]{ "James", "Robert", "John", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles",
						  "Christopher", "Daniel", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua",
						  "Kenneth", "Kevin", "Brian", "George", "Edward", "Ronald", "Timothy", "Jason", "Jeffrey", "Ryan", "Jacob",
						  "Gary", "Nicholas", "Eric", "Jonathan", "Stephen", "Larry", "Justin", "Scott", "Brandon", "Benjamin",
						  "Samuel", "Gregory", "Frank", "Alexander", "Raymond", "Patrick", "Jack", "Dennis", "Jerry", "Tyler", "Aaron",
						  "Jose", "Adam", "Henry", "Nathan", "Douglas", "Zachary", "Peter", "Kyle", "Walter", "Ethan", "Jeremy",
						  "Harold", "Keith", "Christian", "Roger", "Noah", "Gerald", "Carl", "Terry", "Sean", "Austin", "Arthur",
						  "Lawrence", "Jesse", "Dylan", "Bryan", "Joe", "Jordan", "Billy", "Bruce", "Albert", "Willie", "Gabriel",
						  "Logan", "Alan", "Juan", "Wayne", "Roy", "Ralph", "Randy", "Eugene", "Vincent", "Russell", "Elijah", "Louis",
						  "Bobby", "Philip", "Johnny" },
			#endregion

			#region Female Names
			new string[]{ "Mary", "Patricia", "Jennifer", "Linda", "Elizabeth", "Barbara", "Susan", "Jessica", "Sarah", "Karen",
						  "Nancy", "Lisa", "Betty", "Margaret", "Sandra", "Ashley", "Kimberly", "Emily", "Donna", "Michelle",
						  "Dorothy", "Carol", "Amanda", "Melissa", "Deborah", "Stephanie", "Rebecca", "Sharon", "Laura", "Cynthia",
						  "Kathleen", "Amy", "Shirley", "Angela", "Helen", "Anna", "Brenda", "Pamela", "Nicole", "Emma", "Samantha",
						  "Katherine", "Christine", "Debra", "Rachel", "Catherine", "Carolyn", "Janet", "Ruth", "Maria", "Heather",
						  "Diane", "Virginia", "Julie", "Joyce", "Victoria", "Olivia", "Kelly", "Christina", "Lauren", "Joan", "Evelyn",
						  "Judith", "Megan", "Cheryl", "Andrea", "Hannah", "Martha", "Jacqueline", "Frances", "Gloria", "Ann", "Teresa",
						  "Kathryn", "Sara", "Janice", "Jean", "Alice", "Madison", "Doris", "Abigail", "Julia", "Judy", "Grace", "Denise",
						  "Amber", "Marilyn", "Beverly", "Danielle", "Theresa", "Sophia", "Marie", "Diana", "Brittany", "Natalie",
						  "Isabella", "Charlotte", "Rose", "Alexis", "Kayla" },
			#endregion
			
			#region Family Names
			new string[]{ "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez",
						  "Hernandez", "Lopez", "Gonzalez", "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin",
						  "Lee", "Perez", "Thompson", "White", "Harris", "Sanchez", "Clark", "Ramirez", "Lewis", "Robinson", "Walker",
						  "Young", "Allen", "King", "Wright", "Scott", "Torres", "Nguyen", "Hill", "Flores", "Green", "Adams", "Nelson",
						  "Baker", "Hall", "Rivera", "Campbell", "Mitchell", "Carter", "Roberts" }
			#endregion
		};
	}
}
