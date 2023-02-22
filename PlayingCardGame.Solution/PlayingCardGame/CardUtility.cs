using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame
{
    public static class CardUtility
    {
        /// <summary>
        /// 傳回任意張隨機挑選且不重複的牌
        /// </summary>
        /// <param name="countOfCards"></param>
        /// <returns></returns>
        public static IEnumerable<Card> GetRandomCards(int countOfCards)
        {
            var deck = new Deck();
            deck.Shuffle();

            // 最多取52張牌
            if (countOfCards > deck.Cards.Count()) countOfCards = deck.Cards.Count();

            return deck.Cards.Take(countOfCards);
        }

        /// <summary>
        /// 傳回一張隨機挑選的牌
        /// </summary>
        /// <returns></returns>
        public static Card GetRandomCard() => GetRandomCards(1).Single();

        /// <summary>
        /// 將牌按照數字、花色排序
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static List<Card> SortByHighOrLow(this List<Card> cards)
        {
            cards.Sort((x, y) => x.CompareTo(y));
            return cards;
        }

        /// <summary>
        /// 將牌按照數字、花色排序
        /// </summary>
        /// <param name="cards"></param>
        /// <returns></returns>
        public static Card[] SortByHighOrLow(this Card[] cards)
        {
            return cards.ToList().SortByHighOrLow().ToArray();
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
