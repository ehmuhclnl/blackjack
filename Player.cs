using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Player
    {
        private int _score = 0;
        private List<Card> _hands = new List<Card>();
        public List<Card> Hands { get { return _hands; } }

        public void Check(Deck deck)
        {
            _hands.Add(deck.Deal());
            _hands.Add(deck.Deal());
        }
        
        public virtual void Play(Deck deck)
        {
            var score = CalcScore();
            while (!IsBust()) {
                Console.WriteLine("持ち札：" + score);
                Console.WriteLine("Hit or Stand?");
                string input = Console.ReadLine();
                if (input == "Hit") {
                    _hands.Add(deck.Deal());
                    score = CalcScore();
                } else if (input == "Stand") {
                    return;
                }
            }
            Console.WriteLine("Bust");
        }

        public int CalcScore()
        {
            _score = 0;
            foreach (Card card in _hands) {
                _score += card.Score;
            }
            return _score;
        }

        public bool IsBlackjack()
        {
            if(_score == Rule.BlackjackScore) {
                return true;
            } else {
                return false;
            }
        }

        public bool IsBust()
        {
            return _score > Rule.BlackjackScore;
        }

    }
}
