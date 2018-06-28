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
            SongCollection songs = new SongCollection();
            songs[0] = new Song { Name = "", Author = "", Composer = "", Singer = "" };
            songs[1] = new Song { Name = "", Author = "", Composer = "", Singer = "" };
            songs[2] = new Song { Name = "", Author = "", Composer = "", Singer = "" };
            songs[3] = new Song { Name = "", Author = "", Composer = "", Singer = "" };
            songs[4] = new Song { Name = "", Author = "", Composer = "", Singer = "" };

            Iterator iterator = songs.CreateIterator();

        }
    }
}
