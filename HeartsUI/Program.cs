using System;
using Hearts.CardLibrary;

namespace Hearts.HeartsUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var deck = new Deck();
                deck.ShuffleDeck();
                foreach (var card in deck.CardsInDeck)
                {
                    Console.WriteLine(card.ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();
        }
    }
}
