using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Deck 
    {
        private List<Card> _cards = new List<Card>();

        public Deck()
        {
            CreateCards();
        }

        private void CreateCards()
        {
            for (var i = 1; i <= 13; ++i) {
                for (var count = 0; count < 4; ++count) {
                    _cards.Add(new Card(i));
                }
            }
        }

        public Card Deal()
        {
            Random random = new Random();
            var index = random.Next(0, _cards.Count - 1);
            var card = _cards[index];
            _cards.RemoveAt(index);
            //PirntDebug(card);
            return card;
        }
        
        
        
        

        public void PirntDebug()
        {
            foreach (var card in _cards) {
                PirntDebug(card);
            }
        }

        public void PirntDebug(Card card)
        {
            Console.Write(card.Number);
            Console.Write(": ");
            Console.WriteLine(card.Score);
        }
    }
}
