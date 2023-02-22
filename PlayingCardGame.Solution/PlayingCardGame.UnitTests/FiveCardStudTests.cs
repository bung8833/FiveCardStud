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
        public bool IsRoyalFlush_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsRoyalFlush(hand);
        }
        static object[] IsRoyalFlushCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(true), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(true), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsStraightFlushCases))]
        public bool IsStraightFlush_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsStraightFlush(hand);
        }
        static object[] IsStraightFlushCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(true), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(true), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsFourOfAKindCases))]
        public bool IsFourOfAKind_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsFourOfAKind(hand);
        }
        static object[] IsFourOfAKindCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(true), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsFullHouseCases))]
        public bool IsFullHouse_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsFullHouse(hand);
        }
        static object[] IsFullHouseCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(true), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsFlushCases))]
        public bool IsFlush_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsFlush(hand);
        }
        static object[] IsFlushCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(true), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(true), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsStraightCases))]
        public bool IsStraight_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsStraight(hand);
        }
        static object[] IsStraightCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(true), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(true), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(true), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(true), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsThreeOfAKindCases))]
        public bool IsThreeOfAKind_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsThreeOfAKind(hand);
        }
        static object[] IsThreeOfAKindCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(true), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsTwoPairCases))]
        public bool IsTwoPair_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsTwoPair(hand);
        }
        static object[] IsTwoPairCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(true), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsPairCases))]
        public bool IsPair_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsPair(hand);
        }
        static object[] IsPairCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(true), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(false), // HighCard
        };



        [Test, TestCaseSource(nameof(IsHighCardCases))]
        public bool IsHighCard_ㄏノTestCaseSource代刚(Card[] hand)
        {
            return new FiveCardStud().IsHighCard(hand);
        }
        static object[] IsHighCardCases =
        {
            new TestCaseData( new Card[] {new Card(Suits.H, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.S, 11),
                                              new Card(Suits.S, 12),
                                              new Card(Suits.S, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // RoyalFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.S,  9),
                                              new Card(Suits.S, 10),
                                              new Card(Suits.S,  7),
                                              new Card(Suits.S, 11),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),} ).Returns(false), // StraightFlush

            new TestCaseData( new Card[] {new Card(Suits.S,  8),
                                              new Card(Suits.H,  9),
                                              new Card(Suits.C, 10),
                                              new Card(Suits.D, 11),
                                              new Card(Suits.S, 12),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.S, 10),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.C, 12),
                                              new Card(Suits.D, 13),
                                              new Card(Suits.S,  1),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  1),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H,  2),
                                              new Card(Suits.H,  3),
                                              new Card(Suits.H,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // Straight

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.H, 13),
                                              new Card(Suits.H, 12),
                                              new Card(Suits.H, 11),
                                              new Card(Suits.H, 10),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.C,  2),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),
                                              new Card(Suits.C,  7),} ).Returns(false), // Flush

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  3),
                                              new Card(Suits.C,  4),} ).Returns(false), // FourOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  3),
                                              new Card(Suits.S,  3),
                                              new Card(Suits.D,  3),
                                              new Card(Suits.C,  4),
                                              new Card(Suits.C,  5),} ).Returns(false), // ThreeOfAKind

            new TestCaseData( new Card[] {new Card(Suits.H,  6),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // FullHouse

            new TestCaseData( new Card[] {new Card(Suits.H,  5),
                                              new Card(Suits.S,  6),
                                              new Card(Suits.D,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // TwoPair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  7),} ).Returns(false), // Pair

            new TestCaseData( new Card[] {new Card(Suits.H,  4),
                                              new Card(Suits.H,  5),
                                              new Card(Suits.H,  6),
                                              new Card(Suits.H,  7),
                                              new Card(Suits.C,  9),} ).Returns(true), // HighCard
        };
    }
}