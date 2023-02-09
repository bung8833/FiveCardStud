using Newtonsoft.Json.Linq;
using PlayingCardGame.Utilities;

namespace FiveCardStudTests
{
    public class Tests
    {
        [Test]
        public void GetValueDistribution_判斷重複數字的數量分布()
        {
            List<int> values = new List<int>() { 1, 1, 1, 13, 12 };

            List<int> expected = new List<int>() { 1, 1, 3 };




            List<int> actual = values.GetValueDistribution();
            Assert.AreEqual(expected, actual);
        }
    }
}