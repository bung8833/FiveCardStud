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
            for (int i = 0; i < 10; i++)
            {
                RandomCardTest(10000).ToList().ForEach(kvp => Console.Write(kvp + " "));
                Console.WriteLine();
            }

            


            Console.ReadLine();
        }




        private static Dictionary<int, int> RandomCardTest(int cardCount)
        {
            Dictionary<int, int> rankAppearances = new Dictionary<int, int>()
            {
                { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 },
                { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, {10, 0 },
                {11, 0 }, {12, 0 }, {13, 0 },
            };

            for (int i = 0; i < cardCount; i++)
            {
                Card card = CardUtility.GetRandomCard();

                rankAppearances[card.Value] += 1;
            }

            return rankAppearances;
        }
    }
}
