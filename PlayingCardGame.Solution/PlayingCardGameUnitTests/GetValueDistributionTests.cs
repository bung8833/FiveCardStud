using PlayingCardGame;

namespace PlayingCardGameUnitTests
{
    public class Tests
    {
        [Test]
        public void GetValueDistribution_�P�_���ƼƦr���ƶq����()
        {
            List<int> values = new List<int>() { 1, 1, 12, 13, 12 };

            List<int> expected = new List<int>() { 1, 2, 2 };




            List<int> actual = values.GetValueDistribution();
            Assert.AreEqual(expected, actual);
        }
    }
}