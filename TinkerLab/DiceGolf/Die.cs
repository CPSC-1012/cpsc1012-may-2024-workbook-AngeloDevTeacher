using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGolf
{
    internal class Die
    {
        public Die() { }
        public int DieValue
        {
            get {  return dieValue; }
        }
        int dieValue = 1;
        public bool CanRoll = true;

        public void RollDie(Random r)
        {
            dieValue = r.Next(1,7);
        }


    }
}
