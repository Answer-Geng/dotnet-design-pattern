﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Red : IColor
    {
        public void Paint(string letter)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(letter);
        }
    }
}
