using System;
using System.Collections.Generic;
using System.Linq;


namespace _01.Ranking
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, string> contestAndPassword =
				new Dictionary<string, string>();
			SortedDictionary<string, Dictionary<string, int>> ranking =
				new SortedDictionary<string, Dictionary<string, int>>();

			string inputContest = string.Empty;
			string[] separator = { "=>" };

			while ((inputContest = Console.ReadLine()) != "end of contests")
			{
				string[] str = inputContest.Split(':');
				string contest = str[0];
				string password = str[1];
				contestAndPassword.Add(contest, password);
			}
			string inputCollection = string.Empty;
			while ((inputCollection = Console.ReadLine()) != "end of submissions")
			{
				string[] str2 = inputCollection.Split(separator, StringSplitOptions.None);
				string contest = str2[0];
				string password = str2[1];
				string username = str2[2];
				int points = int.Parse(str2[3]);

				if (contestAndPassword.ContainsKey(contest)
					&& contestAndPassword.ContainsValue(password))
				{
					if (ranking.ContainsKey(username) == false)
					{
						ranking.Add(username, new Dictionary<string, int>());
						ranking[username].Add(contest, points);
					}
					if (ranking[username].ContainsKey(contest))
					{
						if (ranking[username][contest] < points)
						{
							ranking[username][contest] = points;
						}
					}
					else
					{
						ranking[username].Add(contest, points);
					}
				}

			}
			Dictionary<string, int> totalPoints = new Dictionary<string, int>();
			foreach (var kvp in ranking)
			{
				totalPoints[kvp.Key] = kvp.Value.Values.Sum();
			}
			string bestCandidate = totalPoints
				.Keys
				.Max();
			int bestPoints = totalPoints
				.Values
				.Max();

			foreach (var kvp in totalPoints)
			{
				if (kvp.Value == bestPoints)
				{
					Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

				}
			}

			Console.WriteLine("Ranking:");
			
			foreach (var name in ranking)
			{
				Dictionary<string, int> dict = name.Value;
				dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
				Console.WriteLine("{0}", name.Key);
				foreach (var kvp in dict)
				{
					Console.WriteLine("#  {0} -> {1}", kvp.Key, kvp.Value);
				}

			}
		}
	}
}