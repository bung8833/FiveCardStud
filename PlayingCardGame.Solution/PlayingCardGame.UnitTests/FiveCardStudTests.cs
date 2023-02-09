namespace PlayingCardGame.UnitTests
{
    public class Tests
    {
        [Test, TestCaseSource(nameof(HandCases))]
        public List<int> GetValueAppearances_使用TestCaseSource測試(List<int> values)
        {
            return values.GetValueAppearances();
        }
        static TestCaseData[] HandCases =
        {
            new TestCaseData(new List<int>{ 5, 6, 5, 6,13 }).Returns(new List<int>{ 1, 2, 2 }),

            new TestCaseData(new List<int>{ 1, 1, 1, 1,13 }).Returns(new List<int>{ 1, 4 }),

            new TestCaseData(new List<int>{13,13,13, 2, 2 }).Returns(new List<int>{ 2, 3 }),

            new TestCaseData(new List<int>{13,13,13, 2, 1 }).Returns(new List<int>{ 1, 1, 3 }),

            new TestCaseData(new List<int>{ 1, 2, 3, 4, 5 }).Returns(new List<int>{ 1, 1, 1, 1, 1 }),
        };



        [Test, TestCaseSource(nameof(IsStraightCases))]
        public bool IsStraight_使用TestCaseSource測試(List<Card> hand)
        {
            //return new FiveCardStud().IsStraight(hand);
            return true;
        }
        static object[] IsStraightCases =
        {
            new TestCaseData( new List<Card> {new Card(Suits.s, 10),
                                              new Card(Suits.s, 11),
                                              new Card(Suits.s, 12),
                                              new Card(Suits.s, 13),
                                              new Card(Suits.s,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new List<Card> {new Card(Suits.s,  8),
                                              new Card(Suits.s,  9),
                                              new Card(Suits.s, 10),
                                              new Card(Suits.s, 11),
                                              new Card(Suits.s, 12),} ).Returns(false), // StraightFlush

            new TestCaseData( new List<Card> {new Card(Suits.s,  8),
                                              new Card(Suits.h,  9),
                                              new Card(Suits.c, 10),
                                              new Card(Suits.d, 11),
                                              new Card(Suits.s, 12),} ).Returns(true), // Straight

            
        };
    }
}