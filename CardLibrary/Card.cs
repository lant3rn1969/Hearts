using System;

namespace CardLibrary
{
    public class Card
    {
        private Suit _suit;
        private CardValue _cardValue;

        public Card(Suit suit, CardValue cardValue)
        {
            _suit = suit;
            _cardValue = cardValue;
        }

        public Suit Suit { get => _suit; }

        public CardValue Value { get => _cardValue; }

        public override string ToString()
        {
            return String.Format("The {0} of {1}", _cardValue, _suit);
        }
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum CardValue
    {
        Ace = 1,
        Deuce,
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
        King
    }
}
