using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    /// <summary>
    /// Base class for any physical object in a game
    /// </summary>
    class GamePiece
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
        public virtual Point Position { get; set; }
        public virtual Point Center { get { return new Point(Position.X + Width / 2, Position.Y + Height / 2)} }


    }
}
