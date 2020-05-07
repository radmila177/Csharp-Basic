using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Homework
{
		public class Person
		{
			public Person(string firstName, string lastName, int age, char gender)
			{
				FirstName = firstName;
				LastName = lastName;
				Age = age;
				Gender = gender;
			}

			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Age { get; set; }

			public char Gender { get; set; }

		}
	class Program
	{
		static void Main(string[] args)
		{

			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more
			Console.WriteLine("1) All people aged 50 or more.");
			List<string> peopleAge50orMore = people
												.Where(a => a.Age >= 50)
												.Select(a => a.FirstName)
												.ToList();
			peopleAge50orMore.ForEach(Console.WriteLine);

			// Task 02
			// all people name starts with B
			Console.WriteLine("2) All people name starts with B");
			List<Person> nameStartwithB = people
											 .Where(x => x.FirstName.StartsWith("B"))
											 .ToList();
			nameStartwithB.ForEach(x => Console.WriteLine(x.FirstName));

			// Task 03
			// first person whose surname starts with T
			Console.WriteLine("3) First person whose surname starts with T");
			Person nameStartsWithT = people
										.Where(x => x.LastName.StartsWith("T"))
										.First();
			Console.WriteLine(nameStartsWithT.LastName);

			// Task 04
			// find youngest and oldest person
			Console.WriteLine("4) Find youngest and oldest person");
			int youngestPerson = people.Min(x => x.Age);
			int oldestPerson = people.Max(x => x.Age);
			Console.WriteLine(youngestPerson);
			Console.WriteLine(oldestPerson);

			// Task 05
			// find all male people aged 45 or more
			Console.WriteLine("5) Find all male people aged 45 or more.");
			List<string> male45orMore = people
									.Where(x => x.Age >= 45 && x.Gender == 'M')
									.Select(x => x.FirstName)
									.ToList();
			male45orMore.ForEach(x => Console.WriteLine(x));

			// Task 06
			// find all females whose name starts with V
			Console.WriteLine("6) Find all females whose name starts with V.");
			List<string> femalesStartsWithV = people
										  .Where(x => x.FirstName.StartsWith("V") &&
												 x.Gender == 'F')
										  .Select(x => x.FirstName)
										  .ToList();
			femalesStartsWithV.ForEach(Console.WriteLine);

			// Task 07
			// find last female person older than 30 whose name starts with p
			Console.WriteLine("7) Find last female person older than 30 whose name starts with P.");
			Person lastfemaleOlder30StartsWithP = people
												 .Where(x => x.FirstName.StartsWith("P") &&
														x.Gender == 'F')
												 .Where(x => x.Age > 30)
												 .LastOrDefault();
			Console.WriteLine(lastfemaleOlder30StartsWithP== null ? "No results found!" : lastfemaleOlder30StartsWithP.FirstName);

			// Task 08
			// find first male younger than 40
			Console.WriteLine("8) Find first male younger than 40");
			Person firstMaleYoungerThan40 = people
											.Where(x => x.Age < 40 && x.Gender == 'M')
											.FirstOrDefault();
			Console.WriteLine(firstMaleYoungerThan40 == null ? "No results found!" : firstMaleYoungerThan40.FirstName);


			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			Console.WriteLine("9) Print the names of the male persons that have firstName longer than lastName");
			Person names = people
								.Where(x => x.FirstName.Length > x.LastName.Length)
							    .Where(x => x.Gender == 'M')
						        .FirstOrDefault();
			Console.WriteLine(names == null ? "No results found!" : names.FirstName);


			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			Console.WriteLine("10) the lastNames of the female persons that have odd number of ages");
			List<string> lastName = people
								.Where(x => x.Age % 2 != 0)
								.Where(x => x.Gender == 'F')
								.Select(x => x.LastName)
								.ToList();
			lastName.ForEach(Console.WriteLine);

			Console.ReadLine();
		}
	}
}
