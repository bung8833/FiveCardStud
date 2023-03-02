using PlayingCardGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1;

            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < 10; i++)
            {
                player1 = new Player(nameof(player1));
                deck.Deal(5).ForEach(c => player1.AddToHand(c));

                Console.WriteLine($"{player1.Name}: {player1}");
                Console.WriteLine($"IsTwoPair: {player1.Hand.IsTwoPair()}");
                Console.WriteLine();
            }
            

            Console.ReadLine();
        }

    }
}
