using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Deck:List<Card>
    {
        public virtual void Shuffle()
        {
            for (int n = this.Count -1; n > 0; --n)
            {
                int k = r.Next(n+1);
                int temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
        }
    }
}
