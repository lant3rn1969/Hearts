using System;
using System.Collections.Generic;
using System.Text;

namespace Hearts.CardLibrary
{
    public class Deck
    {
        private const int MaxDeckCapacity = 52;

        public Deck()
        {
            CardsInDeck = FillDeck();
        }

        public List<Card> CardsInDeck { get; private set; }

        public int Count { get => CardsInDeck.Count; }

        private List<Card> FillDeck()
        {
            var cards = new List<Card> { Capacity = MaxDeckCapacity };

            for (int i = 1; i<=(int)CardValue.King; i++)
            {
                for (int j = 0; j<=(int)Suit.Spades; j++)
                {
                    var suit = (Suit)j;
                    var value = (CardValue)i;

                    cards.Add(new Card(suit, value));
                }
            }

            return cards;
        }

        public void ShuffleDeck()
        {
            var rnd = new Random(DateTime.Now.Second);
            int cardNumber = 0;
            var newCards = new List<Card>();
            for (int i=0; i < MaxDeckCapacity; i++)
            {
                cardNumber = rnd.Next(0, this.CardsInDeck.Count - 1);
                var card = this.CardsInDeck[cardNumber];
                this.CardsInDeck.RemoveAt(cardNumber);
                newCards.Add(card);
            }
            this.CardsInDeck = newCards;
        }
    }
}
