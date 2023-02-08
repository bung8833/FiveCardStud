using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool royal = Hand.All( c => new int[] { 10, 11, 12, 13, 1 }.Contains(c.Value) );

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


            return true;
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
            bool flush = Hand.All(c => c.Suit == Hand[0].Suit);

            return flush;
        }

        /// <summary>
        /// 判斷玩家的手牌 是否為順子
        /// </summary>
        /// <returns></returns>
        public bool IsStraight()
        {
            if (Hand.Count != 5) return false;

            // 數字皆不相同
            bool isDistinct = Hand.Distinct().Count() == 5;
            
            // 數字連續 可以連到A
            bool straight = (Hand.Max().Value - Hand.Min().Value == 4)
                         ||  Hand.All( c => new int[] {10, 11, 12, 13, 1}.Contains(c.Value) );

            return isDistinct && straight;
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
