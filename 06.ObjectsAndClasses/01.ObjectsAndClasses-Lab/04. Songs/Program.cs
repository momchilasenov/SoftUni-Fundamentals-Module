using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 1; i <= numberOfSongs; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split('_', StringSplitOptions.RemoveEmptyEntries);

                Song newSong = new Song //създаваме нова инстанция на класа Song
                {
                    //задаваме НОВИ пропъртита за новата песен (newSong) на база командата
                    TypeList = inputs[0],
                    Name = inputs[1],
                    Time = inputs[2]
                };

                //добавяме новата песен към масива от песни 
                songs.Add(newSong);

            }

            string typeList = Console.ReadLine();
            //1st way
            if (typeList == "all")
            {
                foreach (Song newSong in songs)
                {
                    Console.WriteLine(newSong.Name);
                }
            }
            else
            {
                foreach (Song newSong in songs)
                {
                    if (newSong.TypeList == typeList)
                    {
                        Console.WriteLine(newSong.Name);
                    }
                }
            }

            //2nd way
            songs = songs.FindAll(x => x.TypeList == typeList);
            foreach (var currentSong in songs)
            {
                Console.WriteLine(currentSong.Name);
            }

            //3rd way - начин от функционалното програмиране!
            songs.Where(x => x.TypeList == typeList)
                .ToList()
                .ForEach(x => Console.WriteLine(x.Name));
        }
    }

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }


    }
}
