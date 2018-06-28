using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MusicPlayer
{
    class SongIterator : Iterator
    {
        private SongCollection _songCollection;
        private int _current;

        public SongIterator(SongCollection songCollection)
        {
            this._songCollection = songCollection;
        }

        public object First()
        {
            return _songCollection[0];
        }

        public object Next()
        {
            object song = null;
            if (_current < _songCollection.Count - 1)
            {
                song = _songCollection[++_current];
            }
            return song;
        }

        public bool IsDone()
        {
            return _current >= _songCollection.Count - 1;
        }

        public object CurrentItem()
        {
            return _songCollection[_current];
        }
    }
}
