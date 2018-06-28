using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MusicPlayer
{
    class SongCollection : IAggregate
    {
        private ArrayList _songs = new ArrayList();
        public Iterator CreateIterator()
        {
            return new SongIterator(this);
        }

        public object this[int index]
        {
            get { return _songs[index]; }
            set { _songs.Insert(index, value); }
        }

        public int Count
        {
            get { return _songs.Count; }
        }
    }
}
