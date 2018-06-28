using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            //SongCollection songs = new SongCollection();
            //songs[0] = new Song { Name = "Dance To This", Singer = "Troye Sivan" };
            //songs[1] = new Song { Name = "Ferrari", Singer = "Bebe Rexha" };
            //songs[2] = new Song { Name = "Ocean", Singer = "Martin Garrix" };
            //songs[3] = new Song { Name = "Sober", Singer = "Demi Lovato" };
            //songs[4] = new Song { Name = "Only You", Singer = "Cheat Codes" };

            //Iterator iterator = songs.CreateIterator();
            //var firstSong = iterator.First() as Song;
            //Console.WriteLine($"First Song：{firstSong.Name},Singer：{firstSong.Singer}");
            //while (!iterator.IsDone())
            //{
            //    var currentSong = iterator.Next() as Song;

            //    Console.WriteLine($"Now Playing：{ currentSong.Name},Singer：{currentSong.Singer}");
            //}

            List<Song> songs = new List<Song>();
            songs.Add(new Song { Name = "Dance To This", Singer = "Troye Sivan" });
            songs.Add(new Song { Name = "Ferrari", Singer = "Bebe Rexha" });
            songs.Add(new Song { Name = "Ocean", Singer = "Martin Garrix" });
            songs.Add(new Song { Name = "Sober", Singer = "Demi Lovato" });
            songs.Add(new Song { Name = "Only You", Singer = "Cheat Codes" });

            foreach (var song in songs)
            {
                Console.WriteLine($"Now Playing：{ song.Name},Singer：{song.Singer}");
            }
            Console.ReadLine();
        }
    }
}
