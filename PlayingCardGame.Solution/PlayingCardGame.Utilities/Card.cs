using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame.Utilities
{
    public class Card : IComparable<Card>
    {
        private Suits _suit;

        public Suits Suit
        {
            get => _suit;

            private set
            {
                if (value >= Suits.Club && value <=Suits.Spade)
                {
                    _suit = value;
                }
                else
                {
                    throw new Exception("No such card!\r\nSuit must be within Spade, Heart, Diamond, Club.");
                }
            }
        }

        private int _value;

        public int Value
        {
            get => _value;

            private set
            {
                if (value >= 1 && value <= 13) _value = value;
                else
                {
                    throw new Exception("No such card!\r\nValue must be from 1 to 13");
                }
            }
        }

        public Card(Suits suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        /// <summary>
        /// 根據數字和花色 比較兩張Card的大小
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Card other)
        {
            if (this == null && other == null) return 0;
            if (this == null) return -1;
            if (other == null) return 1;

            // 數字不同 比較數字來決定大小
            if (this.Value != other.Value)
            {
                // Ace最大
                if (this.Value == 1) return 1;
                if (other.Value == 1) return -1;

                return this.Value.CompareTo(other.Value);
            }
            
            // 數字相同 比較花色來決定大小
            return ( (int)this.Suit ).CompareTo( (int)other.Suit );
        }

        /// <summary>
        /// 根據數字和花色 比較兩張Card是否相等
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (this == null && obj == null) return true;
            if (this == null || obj == null) return false;

            Card objAsCard = obj as Card;
            if (objAsCard == null) return false;
            else return (this.Value == objAsCard.Value 
                      && this.Suit == objAsCard.Suit);
        }

        public override string ToString()
        {
            string strValue = String.Empty;

            if (this.Value == 1) strValue = "A";
            else if (this.Value == 10) strValue = "T";
            else if (this.Value == 11) strValue = "J";
            else if (this.Value == 12) strValue = "Q";
            else if (this.Value == 13) strValue = "K";
            else strValue = this.Value.ToString();

            string strSuit = String.Empty;

            if (this.Suit == Suits.Spade) strSuit = "S";
            else if (this.Suit == Suits.Heart) strSuit = "H";
            else if (this.Suit == Suits.Diamond) strSuit = "D";
            else strSuit = "C";

            return strSuit + strValue;
        }

        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        // end of class Card
    }
}
