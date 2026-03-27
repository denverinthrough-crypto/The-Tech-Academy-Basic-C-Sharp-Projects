using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace TwentyOne
{
    public class Dealer // "Dealer object"
    {
        // properties of Dealers
        public string Name { get; set; }
        public Deck Deck { get; set; }  
        public int Balance { get; set; }   
        
        // method
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            
            Console.WriteLine((Deck.Cards.First().ToString() + "\n"));
            
            Deck.Cards.RemoveAt(0);
        }



    }
}
