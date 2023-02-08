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
            List<int> list = new List<int>() { 1, 2, 2, 2, 2 };

            int count = list.GroupBy(x => x).Count();

            Console.WriteLine(count);





            //var player1 = new FiveCardStud();

            //player1.Hand = new List<Card>
            //{
            //    new Card(Suits.s, 10),
            //    new Card(Suits.s, 11),
            //    new Card(Suits.s, 12),
            //    new Card(Suits.s, 13),
            //    new Card(Suits.s, 1),
            //};

            //Console.WriteLine(new FiveCardStud().IsRoyalFlush(player1.Hand));


            Console.ReadLine();
        }
    }
}
