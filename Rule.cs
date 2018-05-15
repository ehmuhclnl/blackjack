using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class Rule
    {
        public static readonly int BlackjackScore = 21;
        public void PrintResult(Player player, Player dealer)
        {
            if (player.IsBust()) {
                Console.WriteLine("プレイヤーの負けです:スコア" + player.CalcScore()+"対"+dealer.CalcScore());
            } else if (player.CalcScore() <= BlackjackScore) {
                if (player.CalcScore() ==  dealer.CalcScore()) {
                    Console.WriteLine("引き分けです:スコア" + player.CalcScore() + "対" + dealer.CalcScore());
                } else if (player.CalcScore() < dealer.CalcScore()) {
                    Console.WriteLine ("プレイヤーの負けです:スコア" + player.CalcScore() + "対" + dealer.CalcScore());
                } else {
                    Console.WriteLine ("プレイヤーの勝ちです:スコア" + player.CalcScore() + "対" + dealer.CalcScore());
                }
            } else {
                Console.WriteLine ("プレイヤーの勝ちです:スコア" + player.CalcScore() + "対" + dealer.CalcScore());
            }
        }
    }
}

