using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Dealer : Player
    {
        public override void Play(Deck deck)
        {
            var score = CalcScore();
            while (score < 17) {
                Hands.Add(deck.Deal());
                score = CalcScore();
            }
        }
    }
}
