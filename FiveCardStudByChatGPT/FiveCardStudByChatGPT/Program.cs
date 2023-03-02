using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveCardStud
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Five Card Stud!");

            // Create a new deck of cards
            Deck deck = new Deck();

            // Shuffle the deck
            deck.Shuffle();

            // Create two players
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            // Deal each player five cards
            for (int i = 0; i < 5; i++)
            {
                player1.AddCard(deck.Deal());
                player2.AddCard(deck.Deal());
            }

            // Show the players' hands
            Console.WriteLine($"{player1.Name}'s hand: {player1}");
            Console.WriteLine($"{player2.Name}'s hand: {player2}");

            // Determine the winner
            int result = player1.Hand.CompareTo(player2.Hand);
            if (result > 0)
            {
                Console.WriteLine($"{player1.Name} wins with {player1}!");
            }
            else if (result < 0)
            {
                Console.WriteLine($"{player2.Name} wins with {player2}!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }


            Console.ReadLine();
        }
    }

    // Represents a playing card
    class Card
    {
        public Suit Suit { get; }
        public Rank Rank { get; }

        public Card(Suit suit, Rank rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    // Represents a deck of cards
    class Deck
    {
        private List<Card> cards = new List<Card>();

        public Deck()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Rank rank in Enum.GetValues(typeof(Rank)))
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }

        public Card Deal()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }

    // Represents a player in the game
    class Player
    {
        public string Name { get; }
        public List<Card> Hand { get; } = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }

        public override string ToString()
        {
            return $"{Name}: {string.Join(", ", Hand)}";
        }
    }

    static class CardExtensions
    {
        public static int CompareTo(this List<Card> source, List<Card> other)
        {
            // First, sort each hand in descending order by rank
            source.Sort((card1, card2) => card2.Rank.CompareTo(card1.Rank));
            other.Sort((card1, card2) => card2.Rank.CompareTo(card1.Rank));

            // Then, compare the hands card by card
            for (int i = 0; i < source.Count; i++)
            {
                int result = source[i].Rank.CompareTo(other[i].Rank);
                if (result != 0)
                {
                    return result;
                }
            }

            // If the hands are identical, return 0
            return 0;
        }
    }

    // Represents the suits of the cards
    enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    // Represents the ranks of the cards
    enum Rank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}

