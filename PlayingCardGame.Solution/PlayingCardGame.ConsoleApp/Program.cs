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
                new Card(Suits.h,  3),
                new Card(Suits.d,  3),
                new Card(Suits.c,  3),
                new Card(Suits.s,  3),
            };
            Console.WriteLine(player1 + " IsFourOfAKind: " + player1.IsFourOfAKind());

            var player2 = new FiveCardStud();

            player2.Hand = new List<Card>
            {
                new Card(Suits.s,  1),
                new Card(Suits.h,  1),
                new Card(Suits.d,  1),
                new Card(Suits.c, 13),
                new Card(Suits.s, 13),
            };
            Console.WriteLine(player2 + " IsFourOfAKind: " + player2.IsFourOfAKind());


            Console.ReadLine();
        }
    }
}
