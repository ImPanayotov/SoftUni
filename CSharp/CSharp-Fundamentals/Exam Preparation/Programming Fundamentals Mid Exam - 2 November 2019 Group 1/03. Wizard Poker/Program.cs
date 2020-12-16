using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Wizard_Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine()
                .Split(":")
                .ToList();

            List<string> newDeck = new List<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "Ready")
                {
                    break;
                }

                if (input[0] == "Add")
                {
                    Add(deck, newDeck, input[1]);
                }
                else if (input[0] == "Remove")
                {
                    Remove(newDeck, input[1]);
                }
                else if (input[0] == "Insert")
                {
                    Insert(deck, newDeck, input[1], input[2]);
                }
                else if (input[0] == "Swap")
                {
                    Swap(newDeck, input[1], input[2]);
                }
                else if (input[0] == "Shuffle")
                {
                    newDeck.Reverse();
                }
            }

            Console.WriteLine(string.Join(" ", newDeck));
        }

        public static List<string> Add(List<string> deck, List<string> newDeck, string input)
        {
            //•	Add { card name}
            //•	Adds the card to the end of the deck.
            //•	If the card doesn't exist in print "Card not found."
            if (deck.Contains(input))
            {
                newDeck.Add(input);
            }
            else
            {
                Console.WriteLine($"Card not found.");
            }

            return newDeck;
        }

        public static List<string> Remove(List<string> newDeck, string input)
        {
            //•	Remove { card name} 
            //•	Remove the card from the deck.
            //•	If the card doesn't exist in print "Card not found."
            if (newDeck.Contains(input))
            {
                newDeck.Remove(input);
            }
            else
            {
                Console.WriteLine("Card not found.");
            }

            return newDeck;
        }

        public static List<string> Insert(List<string> deck, List<string> newDeck, string input, string input2)
        {
            //•	Insert { card name} { index}
            //•	Insert the card at the given index of the deck.
            //•	If the card doesn't exist or the index is invalid print "Error!"
            int index = int.Parse(input2);

            if (deck.Contains(input))
            {
                if (index >= 0 && index < newDeck.Count)
                {
                    newDeck.Insert(index, input);
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }

            return newDeck;
        }

        public static List<string> Swap(List<string> newDeck, string card1, string card2)
        {
            //•	Swap { card name 1} { card name 2} 
            //•	Swap the positions of the cards. 
            //•	Input will always be valid
            int index1 = newDeck.IndexOf(card1);
            int index2 = newDeck.IndexOf(card2);
            string temp = newDeck[index1];
            newDeck[index1] = newDeck[index2];
            newDeck[index2] = temp;

            return newDeck;
        }
    }
}
