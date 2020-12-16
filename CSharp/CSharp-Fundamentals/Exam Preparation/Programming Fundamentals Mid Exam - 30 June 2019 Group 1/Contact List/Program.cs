using System;
using System.Collections.Generic;
using System.Linq;

namespace Contact_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contacts = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string[] commands = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = commands[0];

                if (command == "Print")
                {
                    string direction = commands[1];

                    if (direction == "Normal")
                    {
                        Console.WriteLine("Contacts: " + string.Join(" ", contacts));
                    }
                    else
                    {
                        contacts.Reverse();
                        Console.WriteLine("Contacts: " + string.Join(" ", contacts));
                    }

                    break;
                }

                if (command == "Add")
                {
                    string contact = commands[1];
                    int index = int.Parse(commands[2]);

                    AddContact(contacts, contact, index);
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(commands[1]);

                    RemoveContact(contacts, index);
                }
                else if (command == "Export")
                {
                    int start = int.Parse(commands[1]);
                    int count = int.Parse(commands[2]);

                    ExportContacts(contacts, start, count);
                }
            }
        }

        private static List<string> RemoveContact(List<string> contacts, int index)
        {
            if (index >= 0 && index < contacts.Count)
            {
                contacts.RemoveAt(index);
            }

            return contacts;
        }

        public static List<string> AddContact(List<string> contacts, string contact, int index)
        {
            if (index >= 0 && index < contacts.Count)
            {
                if (contacts.Contains(contact))
                {
                    contacts.Insert(index, contact);
                }
                else
                {
                    contacts.Add(contact);
                }
            }

            return contacts;
        }

        public static void ExportContacts(List<string> contacts, int start, int count)
        {
            if (start >= 0 && start < contacts.Count)
            {
                if (start + count > contacts.Count)
                {
                    for (int i = start; i < contacts.Count; i++)
                    {
                        Console.Write(contacts[i] + " ");
                    }
                }
                else
                {
                    for (int i = start; i < start + count; i++)
                    {
                        Console.Write(contacts[i] + " ");
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
