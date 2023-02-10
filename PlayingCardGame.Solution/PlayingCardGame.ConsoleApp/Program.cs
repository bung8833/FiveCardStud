using PlayingCardGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new FiveCardStud();
            player.Hand = new List<Card>()
            {                                 new Card(Suits.s,  7),
                                              new Card(Suits.s,  8),
                                              new Card(Suits.s,  9),
                                              new Card(Suits.s, 10),
                                              new Card(Suits.s, 11),
            };

            Console.WriteLine(player + "IsStraightFlush: " + player.IsStraightFlush(player.Hand).ToString() );

            Console.ReadLine();
        }
    }
}
