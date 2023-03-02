using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame
{
    public static class PokerHandRankingExtensions
    {
        /// <summary>
        /// 計算List中每種數字的出現次數
        /// 此方法可用來判斷撲克牌牌型
        /// </summary>
        /// <param name="source"></param>
        /// <returns>例如若傳入 { 5, 6, 5, 6, 13 } 則傳回 { 1, 2, 2 }</returns>
        public static List<int> GetValueAppearances(this List<int> source)
        {
            List<int> distincts = source.Distinct().ToList();

            // 計算source中 每個數字各出現幾次
            List<int> vAppearances = new List<int>();
            for (int idx = 0; idx < distincts.Count; idx++)
            {
                int vAppears = source.Count(v => v == distincts[idx]);
                vAppearances.Add(vAppears);
            }

            return vAppearances.OrderBy(v => v).ToList();
        }

        /// <summary>
        /// 判斷傳入的牌是否恰好5張 且數字連續(包含10JQKA)
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        public static bool Are5StraightCards(this Card[] hand)
        {
            if (hand.Count() != 5) return false;

            // 數字必須皆不相同
            if (hand.Select(c => c.Value).Distinct().Count() != 5) return false;

            // 5張不同的牌 其數字連續
            bool continuous = hand.Select(c => c.Value).Max()
                            - hand.Select(c => c.Value).Min() == 4;

            // 10 J Q K A
            bool royal = hand.Select(h => h.Value).All(new int[] { 10, 11, 12, 13, 1 }.Contains);

            return continuous || royal;
        }
    }

    public static class FiveCardStudExtensions
    {
        /// <summary>
        /// 判斷玩家的手牌 是否為同花大順(10JQKA)
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsRoyalFlush(this Card[] Hand)
        {
            return FiveCardStud.IsRoyalFlush(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為同花順
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsStraightFlush(this Card[] Hand)
        {
            return FiveCardStud.IsStraightFlush(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為四條
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsFourOfAKind(this Card[] Hand)
        {
            return FiveCardStud.IsFourOfAKind(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為葫蘆
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsFullHouse(this Card[] Hand)
        {
            return FiveCardStud.IsFullHouse(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為同花
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsFlush(this Card[] Hand)
        {
            return FiveCardStud.IsFlush(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為順子
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsStraight(this Card[] Hand)
        {
            return FiveCardStud.IsStraight(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為三條
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsThreeOfAKind(this Card[] Hand)
        {
            return FiveCardStud.IsThreeOfAKind(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為兩對
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsTwoPair(this Card[] Hand)
        {
            return FiveCardStud.IsTwoPair(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為一對
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsPair(this Card[] Hand)
        {
            return FiveCardStud.IsPair(Hand);
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為單張
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public static bool IsHighCard(this Card[] Hand)
        {
            return FiveCardStud.IsHighCard(Hand);
        }
    }
}
