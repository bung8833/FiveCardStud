using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public static class CardUtility
    {
        /// <summary>
        /// 隨機選取任意張不重複的牌
        /// </summary>
        /// <param name="countOfCard"></param>
        /// <returns></returns>
        public static List<Card> GetRandomCards(int countOfCard)
        {
            Suits[] suits = new Suits[] { Suits.Spade, Suits.Heart, Suits.Diamond, Suits.Club };
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            List<Card> deckOfCards = suits.Join(values,
                s => 1,
                v => 1,
                (s, v) => new Card(s , v))
                .ToList();

            List<Card> result = new List<Card>();

            // 最多取52張牌
            if (countOfCard > deckOfCards.Count)countOfCard = deckOfCards.Count;

            while (result.Count < countOfCard)
            {
                Random seed = new Random(Guid.NewGuid().GetHashCode());
                int index = seed.Next(0, deckOfCards.Count); // [0, deckOfCards.Count)

                result.Add(deckOfCards[index]);
                deckOfCards.RemoveAt(index); // 取完就丟掉 才不會取到重覆的牌
            }

            return result;
        }

        /// <summary>
        /// 將牌按照數字、花色排序
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static void SoryByHighOrLow(this List<Card> cards)
        {
            cards.Sort((x, y) => x.CompareTo(y));
        }

        /// <summary>
        /// 根據數字和花色 判斷是否所有Card皆相等
        /// </summary>
        /// <param name="source"></param>
        /// <param name="firstCard"></param>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static bool Equals(this Card source, Card firstCard, params Card[] cards)
        {
            if (firstCard == null) return false;

            if (source.Value != firstCard.Value 
                || source.Suit != firstCard.Suit)
            {
                return false;
            }

            if (cards == null) return true;
            foreach (var card in cards)
            {
                if (source.Value != card.Value
                 || source.Suit != card.Suit)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
