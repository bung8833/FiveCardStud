using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingCardGame.Utilities
{
    public class FiveCardStud
    {
        private List<Card> _hand = new List<Card>();

        /// <summary>
        /// 玩家的手牌 介於0~5張 且不應有重複的牌
        /// </summary>
        public List<Card> Hand
        {
            get
            {
                if (_hand.Count > 5)
                {
                    throw new Exception("一手牌最多只能有5張");
                }
                if (_hand.Distinct().Count() < _hand.Count())
                {
                    throw new Exception("一手牌內不可有重複的牌");
                }

                return _hand;
            }
            set
            {
                _hand = value;

                if (_hand.Count > 5)
                {
                    throw new Exception("一手牌最多只能有5張");
                }
                if (_hand.Distinct().Count() < _hand.Count())
                {
                    throw new Exception("一手牌內不可有重複的牌");
                }
            }
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
            else return (this.Hand.Count == objAsStud.Hand.Count
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



        // todo 用LINQ判斷牌型

        /// <summary>
        /// 判斷玩家的手牌 是否為同花大順
        /// </summary>
        /// <returns></returns>
        public bool IsRoyalFlush()
        {
            if (Hand.Count != 5) return false;

            // 數字是10, J, Q, K, A
            bool royal = Hand.All(c => new int[] { 10, 11, 12, 13, 1 }.Contains(c.Value));
            // 是同花
            bool flush = IsFlush();

            return royal && flush;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為同花順
        /// </summary>
        /// <returns></returns>
        public bool IsStraightFlush()
        {
            if (Hand.Count != 5) return false;

            // 是同花
            bool flush = IsFlush();

            // 是順子
            bool straight = IsStraight();

            return flush && straight;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為四條
        /// </summary>
        /// <returns></returns>
        public bool IsFourOfAKind()
        {
            if (Hand.Count != 5) return false;

            // 只出現兩種數字
            bool twoNums = Hand.Select(h => h.Value).Distinct().Count() == 2;
            //bool twoNums = Hand.Select(h => h.Value).GroupBy(x => x).Count() == 2;

            // 4張相同數字 + 1張其他數字
            List<int> values = Hand.Select(h => h.Value).ToList();

            bool four = values.Count(v => v == values[0]) == 4
                     || values.Count(v => v == values[1]) == 4;

            return twoNums && four;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為葫蘆
        /// </summary>
        /// <returns></returns>
        public bool IsFullHouse()
        {
            if (Hand.Count != 5) return false;


            return true;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為同花
        /// </summary>
        /// <returns></returns>
        public bool IsFlush()
        {
            if (Hand.Count != 5) return false;

            // 所有牌花色相同
            bool flush = Hand.Select(h => h.Suit).Distinct().Count() == 1;

            return flush;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為順子
        /// </summary>
        /// <returns></returns>
        public bool IsStraight()
        {
            if (Hand.Count != 5) return false;

            // 數字必須皆不相同
            if ( Hand.Select(h => h.Value).Distinct().Count() != 5 ) return false;

            // 5張不同的牌 其數字連續
            bool continuous = Hand.Select(h => h.Value).Max()
                             -Hand.Select(h => h.Value).Min() == 4;

            // 10 J Q K A
            bool royal = Hand.All( c => new int[] { 10,11,12,13,1 }.Contains(c.Value) );

            return continuous || royal;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為三條
        /// </summary>
        /// <returns></returns>
        public bool IsThreeOfAKind()
        {
            if (Hand.Count != 5) return false;


            return true;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為兩對
        /// </summary>
        /// <returns></returns>
        public bool IsTwoPair()
        {
            if (Hand.Count != 5) return false;


            return true;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為一對
        /// </summary>
        /// <returns></returns>
        public bool IsPair()
        {
            if (Hand.Count != 5) return false;


            return true;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為單張
        /// </summary>
        /// <returns></returns>
        public bool IsHighCard()
        {
            if (Hand.Count != 5) return false;


            return true;
        }

        // end of class FiveCardStud
    }
}
