﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_MusicPlayer
{
    interface IAggregate
    {
        Iterator CreateIterator();
    }
}
