﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Deck:List<Card>, PlayingSurface
    {
        public virtual void Shuffle()
        {

        }
    }
}
