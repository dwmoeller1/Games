using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    public class Player
    {
        public virtual int Id { get; set; }
        public virtual Color? Color { get; set; }
        public virtual string Name { get; set; }

        public Player(int id)
        {
            this.Id = id;
            this.Color = null;
            this.Name = id.ToString();
        }

        public Player(string name)
        {
            this.Name = name;
            int result;
            if (int.TryParse(name, out result))
                this.Id = result;
        }

        public Player(int id, string name, Color? color =null)
        {
            this.Id = id;
            this.Name = name;
            this.Color = color;
        }
    }
}
