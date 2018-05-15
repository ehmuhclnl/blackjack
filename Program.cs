using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //var deck = new Deck();
            //deck.Deal();
            var deck = new Deck();
            var player = new Player();
            var dealer = new Dealer();
            var rule = new Rule();
            player.Check(deck);
            dealer.Check(deck);
            player.Play(deck);
            dealer.Play(deck);
            rule.PrintResult(player, dealer);
        }
    }
}
