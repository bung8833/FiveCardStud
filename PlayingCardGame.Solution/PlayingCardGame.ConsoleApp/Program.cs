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
                new Card(Suits.s, 10),
                new Card(Suits.h, 11),
                new Card(Suits.s, 11),
                new Card(Suits.d,  1),
                new Card(Suits.d, 11),
            };
            player1.Hand.SoryByHighOrLow();

            Console.WriteLine(player1 + "為同花大順: " + player1.IsRoyalFlush());








            //var deck1 = new Deck();
            //deck1.Shuffle();
            //Console.WriteLine(deck1);

            //List<Card> cards = new List<Card>();

            //for (int i = 0; i < 10; i++)
            //{
            //    cards = deck1.Deal(5);
            //    cards.SoryByHighOrLow();
            //    cards.ForEach(c => Console.Write(c + " "));
            //    Console.WriteLine();
            //}
            Console.ReadLine();
        }
    }
}
