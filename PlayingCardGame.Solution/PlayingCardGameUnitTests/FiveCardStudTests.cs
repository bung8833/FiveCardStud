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
        public void FiveCardStud_IsStraight()
        {
            var player1 = new FiveCardStud();
            player1.Hand = new List<Card>
            {
                new Card(Suits.s, 11),
                new Card(Suits.h, 12),
                new Card(Suits.c, 13),
                new Card(Suits.d,  1),

                new Card(Suits.s,  2),
            };
            bool expected = false;
            bool actual = player1.IsStraight();
            Assert.AreEqual(expected, actual);
        }
    }
}