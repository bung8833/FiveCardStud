using PlayingCardGame;

namespace PlayingCardGameUnitTests
{
    public class Tests
    {
        //[Test]
        //public void GetValueDistribution_判斷重複數字的數量分布()
        //{
        //    List<int> values = new List<int>() { 1, 1, 12, 13, 12 };

        //    List<int> expected = new List<int>() { 1, 2, 2 };




        //    List<int> actual = values.GetValueDistribution();
        //    Assert.AreEqual(expected, actual);
        //}

        [Test]
        public void IsPair_判斷牌型()
        {
            var player1 = new FiveCardStud();
            player1.Hand = new List<Card>
            {
                new Card(Suits.s,  9),
                new Card(Suits.h,  9),
                new Card(Suits.c,  8),
                new Card(Suits.d,  7),

                new Card(Suits.s, 11),
            };
            bool expected = true;
            bool actual = player1.IsPair();
            Assert.AreEqual(expected, actual);
        }
    }
}