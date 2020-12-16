using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    //class Song
    //{
    //    public string TypeList { get; set; }

    //    public string Name { get; set; }

    //    public string Time { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < count; i++)
            {
                string[] inputInfo = Console.ReadLine().Split("_");
                string typeList = inputInfo[0];
                string name = inputInfo[1];
                string time = inputInfo[2];

                Song song = new Song();
                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;
                songs.Add(song);

            }

            string targetListType = Console.ReadLine();

            if (targetListType == "all")
            {
                foreach (Song currentSong in songs)
                {
                    Console.WriteLine(currentSong.Name);
                }
            }
            else
            {
                foreach (Song currentSong in songs)
                {
                    if (currentSong.TypeList == targetListType)
                    {
                        Console.WriteLine(currentSong.Name);
                    }
                }
            }
            //foreach (Song currentSong in songs)
            //{
            //    if (currentSong.TypeList == targetListType)
            //    {
            //        Console.WriteLine(currentSong.Name);
            //    }
            //}
            //#################################################
            //songs = songs.FindAll(x => x.TypeList == targetListType);

            //foreach (var currentSong in songs)
            //{
            //    Console.WriteLine(currentSong.Name);
            //}
            //#################################################
            //songs.Where(x => x.TypeList == targetListType)
            //    .ToList()
            //    .ForEach(x => Console.WriteLine(x.Name));


        }
    }
}
