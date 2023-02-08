using PlayingCardGame.Utilities;
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
            var player1 = new FiveCardStud();

            player1.Hand = new List<Card>
            {
                new Card(Suits.s,  2),
                new Card(Suits.h,  2),
                new Card(Suits.d,  2),
                new Card(Suits.c, 10),
                new Card(Suits.c,  2),
            };

            Console.WriteLine(player1 + " IsFourOfAKind: " + player1.IsFourOfAKind());


            Console.ReadLine();
        }
    }
}
