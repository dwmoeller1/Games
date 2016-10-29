using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class PlayingSurface
    {        
        public int Height { get; set; }
        public int Width { get; set; }
        public Point Position { get; set; }

        public Point Center { get { return new Point(Position.X + Width / 2, Position.Y + Height / 2); } }
    }
}
