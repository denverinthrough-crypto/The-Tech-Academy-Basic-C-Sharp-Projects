using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); // deck object created from the Deck class

            deck = Shuffle(deck); // call function for shuffled deck of cards

            foreach(Card card in deck.Cards) // 
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
    
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck) // Function or method
        {
            List<Card> TempList = new List<Card>(); 
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);

            }
            deck.Cards = TempList;
            return deck;

        }

    }
}