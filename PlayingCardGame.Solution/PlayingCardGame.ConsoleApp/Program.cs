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
            var deck1 = new Deck();
            deck1.Shuffle();

            var hand1 = deck1.Deal(5).SoryByHighOrLow();
            var hand2 = deck1.Deal(5).SoryByHighOrLow();


            hand1.ForEach(c => Console.Write(c + " ")); Console.WriteLine();
            hand2.ForEach(c => Console.Write(c + " ")); Console.WriteLine();


            Console.ReadLine();
        }
    }
}
