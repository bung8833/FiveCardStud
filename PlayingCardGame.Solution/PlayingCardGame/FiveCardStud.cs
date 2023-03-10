using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame
{
    public class FiveCardStud
    {
        private List<Card> _hand = new List<Card>();

        /// <summary>
        /// 玩家的手牌情況
        /// </summary>
        public Card[] Hand
        {
            get { return _hand.ToArray(); }
        }

        /// <summary>
        /// 發一張牌到玩家的手牌中
        /// </summary>
        /// <param name="addend"></param>
        /// <returns>發牌後 玩家的手牌情況</returns>
        /// <exception cref="Exception"></exception>
        public Card[] AddToHand(Card addend)
        {
            if (_hand.Count + 1 > 5)
            {
                throw new Exception("手牌最多只能有5張");
            }
            if (_hand.Contains(addend))
            {
                throw new Exception("手牌內不可有完全相同的牌");
            }

            _hand.Add(addend);

            return _hand.ToArray();
        }


        /// <summary>
        /// 判斷兩副手牌中的牌是否相同 只比較其值 不管順序
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (this == null && obj == null) return true;
            if (this == null || obj == null) return false;

            FiveCardStud objAsStud = obj as FiveCardStud;
            if (objAsStud == null) return false;
            else return (this.Hand.Count() == objAsStud.Hand.Count()
                         && this.Hand.All(objAsStud.Hand.Contains));
        }

        public override string ToString()
        {
            string result = String.Empty;

            foreach (Card card in Hand)
            {
                result += card.ToString() + " ";
            }

            return result;
        }

        public override int GetHashCode()
        {
            return Hand.GetHashCode();
        }



        /// <summary>
        /// 判斷玩家的手牌 是否為同花大順(10JQKA)
        /// </summary>
        /// <returns></returns>
        public bool IsRoyalFlush(Card[] Hand)
        {
            if (Hand.Count() != 5) return false;

            // 數字是10, J, Q, K, A
            bool royal = Hand.Select(h => h.Value).All(new int[] { 10, 11, 12, 13, 1 }.Contains);

            // 是同花
            bool flush = Hand.Select(c => c.Suit).Distinct().Count() == 1;

            return royal && flush;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為同花順
        /// </summary>
        /// <returns></returns>
        public bool IsStraightFlush(Card[] Hand)
        {
            if ( IsRoyalFlush(Hand) ) return false;
            if (Hand.Count() != 5) return false;

            // 是同花
            bool flush = Hand.Select(c => c.Suit).Distinct().Count() == 1;

            // 是順子
            bool straight = Hand.Are5StraightCards();

            return flush && straight;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為四條
        /// </summary>
        /// <returns></returns>
        public bool IsFourOfAKind(Card[] Hand)
        {
            if (Hand.Count() != 5) return false;

            List<int> values = Hand.Select(c => c.Value).ToList();

            // 手牌中每種數字的出現次數
            List<int> vAppears = values.GetValueAppearances();

            // 4張相同數字 + 1張其他數字
            if (vAppears.SequenceEqual(new List<int> { 1, 4 }))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為葫蘆
        /// </summary>
        /// <returns></returns>
        public bool IsFullHouse(Card[] Hand)
        {
            if (Hand.Count() != 5) return false;

            List<int> values = Hand.Select(c => c.Value).ToList();

            // 手牌中重複數字的數量分布
            List<int> vAppears = values.GetValueAppearances();

            // 3張相同數字 + 另外2張相同數字
            if (vAppears.SequenceEqual(new List<int> { 2, 3 }))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為同花
        /// </summary>
        /// <returns></returns>
        public bool IsFlush(Card[] Hand)
        {
            if ( Hand.Are5StraightCards() ) return false;
            if (Hand.Count() != 5) return false;

            // 所有牌花色相同
            bool flush = Hand.Select(c => c.Suit).Distinct().Count() == 1;

            return flush;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為順子
        /// </summary>
        /// <returns></returns>
        public bool IsStraight(Card[] Hand)
        {
            bool flush = Hand.Select(c => c.Suit).Distinct().Count() == 1;
            if (flush) return false;
            //if (Hand.Count() != 5) return false;

            return Hand.Are5StraightCards();
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為三條
        /// </summary>
        /// <returns></returns>
        public bool IsThreeOfAKind(Card[] Hand)
        {
            if (Hand.Count() != 5) return false;

            List<int> values = Hand.Select(c => c.Value).ToList();

            // 手牌中重複數字的數量分布fv
            List<int> vAppears = values.GetValueAppearances();

            // 3張相同數字 + 單張 + 單張
            if (vAppears.SequenceEqual(new List<int> { 1, 1, 3 }))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為兩對
        /// </summary>
        /// <returns></returns>
        public bool IsTwoPair(Card[] Hand)
        {
            if (Hand.Count() != 5) return false;

            List<int> values = Hand.Select(c => c.Value).ToList();

            // 手牌中重複數字的數量分布
            List<int> vAppears = values.GetValueAppearances();

            // 2張相同數字 + 2張相同數字 + 單張
            if (vAppears.SequenceEqual(new List<int> { 1, 2, 2 }))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為一對
        /// </summary>
        /// <returns></returns>
        public bool IsPair(Card[] Hand)
        {
            if (Hand.Count() != 5) return false;

            List<int> values = Hand.Select(c => c.Value).ToList();

            // 手牌中重複數字的數量分布
            List<int> vAppears = values.GetValueAppearances();

            // 2張相同數字 + 單張 + 單張 + 單張
            if (vAppears.SequenceEqual(new List<int> { 1, 1, 1, 2 }))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為單張
        /// </summary>
        /// <returns></returns>
        public bool IsHighCard(Card[] Hand)
        {
            if (Hand.Count() != 5) return false;

            // 數字必須皆不相同
            if ( Hand.Select(c => c.Value).Distinct().Count() != 5 ) return false;

            // 不是順子
            if ( Hand.Are5StraightCards() ) return false;

            // 不是同花
            if ( Hand.Select(c => c.Suit).Distinct().Count() == 1 ) return false;

            return true;
        }

        // end of class FiveCardStud
    }
}
