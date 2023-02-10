namespace PlayingCardGame.UnitTests
{
    public class Tests
    {
        [Test, TestCaseSource(nameof(HandCases))]
        public List<int> GetValueAppearances_ㄏノTestCaseSource代刚(List<int> values)
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



        [Test, TestCaseSource(nameof(IsRoyalFlushCases))]
        public bool IsRoyalFlush_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsRoyalFlush(hand);
        }
        static object[] IsRoyalFlushCases =
        {
            
        };



        [Test, TestCaseSource(nameof(IsStraightFlushCases))]
        public bool IsStraightFlush_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsStraightFlush(hand);
        }
        static object[] IsStraightFlushCases =
        {

        };



        [Test, TestCaseSource(nameof(IsFourOfAKindCases))]
        public bool IsFourOfAKind_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsFourOfAKind(hand);
        }
        static object[] IsFourOfAKindCases =
        {

        };



        [Test, TestCaseSource(nameof(IsFullHouseCases))]
        public bool IsFullHouse_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsFullHouse(hand);
        }
        static object[] IsFullHouseCases =
        {

        };



        [Test, TestCaseSource(nameof(IsFlushCases))]
        public bool IsFlush_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsFlush(hand);
        }
        static object[] IsFlushCases =
        {

        };



        [Test, TestCaseSource(nameof(IsStraightCases))]
        public bool IsStraight_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsStraight(hand);
        }
        static object[] IsStraightCases =
        {
            new TestCaseData( new List<Card> {new Card(Suits.h, 10),
                                              new Card(Suits.h, 11),
                                              new Card(Suits.h, 12),
                                              new Card(Suits.h, 13),
                                              new Card(Suits.h,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new List<Card> {new Card(Suits.s, 10),
                                              new Card(Suits.s, 11),
                                              new Card(Suits.s, 12),
                                              new Card(Suits.s, 13),
                                              new Card(Suits.s,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new List<Card> {new Card(Suits.s,  8),
                                              new Card(Suits.s,  9),
                                              new Card(Suits.s, 10),
                                              new Card(Suits.s,  7),
                                              new Card(Suits.s, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new List<Card> {new Card(Suits.h,  1),
                                              new Card(Suits.h,  2),
                                              new Card(Suits.h,  3),
                                              new Card(Suits.h,  4),
                                              new Card(Suits.h,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new List<Card> {new Card(Suits.s,  8),
                                              new Card(Suits.h,  9),
                                              new Card(Suits.c, 10),
                                              new Card(Suits.d, 11),
                                              new Card(Suits.s, 12),} ).Returns(true), // Straight

            new TestCaseData( new List<Card> {new Card(Suits.s, 10),
                                              new Card(Suits.h, 11),
                                              new Card(Suits.c, 12),
                                              new Card(Suits.d, 13),
                                              new Card(Suits.s,  1),} ).Returns(true), // Straight

            new TestCaseData( new List<Card> {new Card(Suits.h,  1),
                                              new Card(Suits.h,  2),
                                              new Card(Suits.h,  3),
                                              new Card(Suits.h,  4),
                                              new Card(Suits.c,  5),} ).Returns(true), // Straight

            new TestCaseData( new List<Card> {new Card(Suits.h,  6),
                                              new Card(Suits.h,  2),
                                              new Card(Suits.h,  3),
                                              new Card(Suits.h,  4),
                                              new Card(Suits.c,  5),} ).Returns(true), // Straight

            new TestCaseData( new List<Card> {new Card(Suits.h,  3),
                                              new Card(Suits.s,  3),
                                              new Card(Suits.d,  3),
                                              new Card(Suits.c,  3),
                                              new Card(Suits.c,  7),} ).Returns(false), // FourOfAKind

            new TestCaseData( new List<Card> {new Card(Suits.h,  3),
                                              new Card(Suits.d,  4),
                                              new Card(Suits.h,  3),
                                              new Card(Suits.h,  6),
                                              new Card(Suits.c,  7),} ).Returns(false), // Pair
        };



        [Test, TestCaseSource(nameof(IsThreeOfAKindCases))]
        public bool IsThreeOfAKind_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsThreeOfAKind(hand);
        }
        static object[] IsThreeOfAKindCases =
        {

        };



        [Test, TestCaseSource(nameof(IsTwoPairCases))]
        public bool IsTwoPair_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsTwoPair(hand);
        }
        static object[] IsTwoPairCases =
        {

        };



        [Test, TestCaseSource(nameof(IsPairCases))]
        public bool IsPair_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsPair(hand);
        }
        static object[] IsPairCases =
        {

        };



        [Test, TestCaseSource(nameof(IsHighCardCases))]
        public bool IsHighCard_ㄏノTestCaseSource代刚(List<Card> hand)
        {
            return new FiveCardStud().IsHighCard(hand);
        }
        static object[] IsHighCardCases =
        {

        };
    }
}