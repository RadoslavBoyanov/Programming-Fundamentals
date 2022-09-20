using System;
using System.Collections.Generic;

namespace _03Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> newList = new List<Song>();


            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] receivingSong = Console.ReadLine().Split('_');

                Song song = new Song(receivingSong[0], receivingSong[1], receivingSong[2]);

                newList.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in newList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in newList)
                {
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }

        class Song
        {
            public Song(string typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;  
                this.Time = time;   
            }

           public string TypeList { get; set; }
           public string Name { get; set; }
           public string Time { get; set; }
        }
    }
}
