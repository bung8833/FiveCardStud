using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCardGame
{
    public class Player
    {
        /// <summary>
        /// 玩家的名字
        /// </summary>
        public string Name { get; }

        public Player(string name)
        {
            this.Name = name;
        }

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
        /// <param name="card"></param>
        /// <returns>發牌後 玩家的手牌情況</returns>
        /// <exception cref="Exception"></exception>
        public Card[] AddToHand(Card card)
        {
            if (_hand.Count + 1 > 5)
            {
                throw new Exception("手牌最多只能有5張");
            }
            if (_hand.Contains(card))
            {
                throw new Exception("手牌內不可有相同的牌");
            }

            _hand.Add(card);
            _hand.SortByHighOrLow();

            return _hand.ToArray();
        }

        public override string ToString()
        {
            return String.Join<Card>(" ", this.Hand);
        }
    }
}
