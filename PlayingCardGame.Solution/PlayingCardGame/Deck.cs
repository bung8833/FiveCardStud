using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame
{
    public class Deck
    {
        /// <summary>
        /// 目前存在這副牌中的牌
        /// </summary>
        public List<Card> Cards { get; private set; }

        /// <summary>
        /// 取得全部52張牌
        /// </summary>
        public Deck()
        {
            Suits[] suits = new Suits[] { Suits.Club, Suits.Diamond, Suits.Heart, Suits.Spade };
            int[] ranks = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Cards = suits.Join(ranks, s => 1, v => 1, (s, v) => new Card(s, v))
                        .ToList();
        }

        /// <summary>
        /// 只取得一部分的牌 可以傳入想要的數字來決定要生成哪些牌 
        /// </summary>
        /// <param name="ranks"></param>
        /// <exception cref="Exception"></exception>
        public Deck(int[] ranks)
        {
            if (ranks.Max() > 13 || ranks.Min() < 1)
            {
                throw new Exception("Ranks must be from 1 to 13");
            }

            Suits[] suits = new Suits[] { Suits.Club, Suits.Diamond, Suits.Heart, Suits.Spade };

            Cards = suits.Join(ranks, s => 1, v => 1, (s, v) => new Card(s, v))
                         .ToList();
        }

        /// <summary>
        /// 判斷兩副Deck中的牌 其值和順序是否相同
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (this == null && obj == null) return true;
            if (this == null || obj == null) return false;

            Deck objAsDeck = obj as Deck;
            if (objAsDeck == null) return false;
            else return (this.Cards.SequenceEqual(objAsDeck.Cards));
        }

        public override string ToString()
        {
            string result = String.Empty;

            foreach (Card card in Cards)
            {
                result += card.ToString() + " ";
            }

            return result;
        }

        public override int GetHashCode()
        {
            return this.Cards.GetHashCode();
        }

        /// <summary>
        /// 將Deck中的Cards洗牌
        /// </summary>
        public Deck Shuffle()
        {
            int n = Cards.Count;

            Random rand = new Random(Guid.NewGuid().GetHashCode());
            while (n > 0)
            {
                n--;
                int index = rand.Next(0, n);

                Card temp = Cards[n];
                Cards[n] = Cards[index];
                Cards[index] = temp;
            }

            return this;
        }

        /// <summary>
        /// 向Deck索取下N張牌 若叫用時已被取光 或剩下數量不足 則丟出例外
        /// </summary>
        /// <param name="countOfDeal"></param>
        /// <returns></returns>
        public List<Card> Deal(int countOfDeal)
        {
            if (countOfDeal > this.Cards.Count)
            {
                throw new Exception("Not enough Cards!");
            }

            List<Card> nextCards = this.Cards.Take(countOfDeal).ToList();
            this.Cards.RemoveRange(0, countOfDeal);

            return nextCards;
        }

        /// <summary>
        /// 向Deck索取下一張牌 若叫用時已被取光 則丟出例外
        /// </summary>
        /// <returns></returns>
        public Card Deal() => Deal(1).Single();


        // end of Deck
    }
}
