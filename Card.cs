using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Card  
    {
        private int _number;
        public int Number { get { return _number; } set { _number = value; } }
        public int Score { get { return _number > 10 ? 10 : _number; } }

        public Card(int number)
        {
            _number = number;
        }
        
    }
}
