using System;
using System.Collections.Generic;
using System.IO;

namespace MusicApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songs = new List<Song>();
            StreamReader sr = null;
            try
            {
                sr = new StreamReader(@"C:\Users\FBenji2\source\repos\hazi1-2019-FBenji2\Feladat1\Input\music.txt");
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] lineItems = line.Split(';');
                    if (lineItems.Length == 0)
                        continue;
                    string artist = lineItems[0].Trim();

                    for(int i=1;i < lineItems.Length;i++)
                    {
                        Song song = new Song(artist, lineItems[i].Trim());
                        songs.Add(song);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("A fájl feldolgozása sikertelen");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null)
                    sr.Close();
            }
            foreach (Song song in songs)
                Console.WriteLine(song.ToString());
            Console.ReadKey();
        }
    }
}
