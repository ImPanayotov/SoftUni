using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPool =
                new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ").ToArray();

                if (input[0] == "Season end")
                {
                    break;
                }

                if (input.Length <= 1)
                {
                    string[] playersToFight = input[0].Split(" vs ").ToArray();
                    string firstPlayer = playersToFight[0];
                    string secondPlayer = playersToFight[1];

                    if (playerPool.ContainsKey(firstPlayer)
                        && playerPool.ContainsKey(secondPlayer))
                    {
                        if (playerPool[firstPlayer].Count >= playerPool[secondPlayer].Count)
                        {
                            foreach (var position in playerPool[firstPlayer])
                            {
                                if (playerPool[secondPlayer].ContainsKey(position.Key))
                                {
                                    int sumP1 = playerPool[firstPlayer].Values.Sum();
                                    int sumP2 = playerPool[secondPlayer].Values.Sum();

                                    if (sumP1 > sumP2)
                                    {
                                        playerPool.Remove(secondPlayer);
                                    }
                                    else if (sumP2 > sumP1)
                                    {
                                        playerPool.Remove(firstPlayer);
                                    }
                                    break;
                                }
                            }
                        }
                        else
                        {
                            foreach (var position in playerPool[secondPlayer])
                            {
                                if (playerPool[firstPlayer].ContainsKey(position.Key))
                                {
                                    int sumP1 = playerPool[firstPlayer].Values.Sum();
                                    int sumP2 = playerPool[secondPlayer].Values.Sum();

                                    if (sumP1 > sumP2)
                                    {
                                        playerPool.Remove(secondPlayer);
                                    }
                                    else if (sumP2 > sumP1)
                                    {
                                        playerPool.Remove(firstPlayer);
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    string player = input[0];
                    string position = input[1];
                    int skill = int.Parse(input[2]);

                    if (!playerPool.ContainsKey(player))
                    {
                        playerPool.Add(player, new Dictionary<string, int>());
                        playerPool[player].Add(position, skill);
                    }
                    else
                    {
                        if (playerPool[player].ContainsKey(position))
                        {
                            if (playerPool[player][position] < skill)
                            {
                                playerPool[player][position] = skill;
                            }
                        }
                        else
                        {
                            playerPool[player].Add(position, skill);
                        }
                    }
                }
            }

            foreach (var player in playerPool.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var position in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
