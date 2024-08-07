using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLists
{
    internal class Creature : Card
    {
        private string _cardName;
        private List<Keyword> _keywords;
        private List<Mana> _cost;


        public Creature() { }
    }
}
