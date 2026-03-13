using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer // inherit from Dealer class
    {
        private List<Card> _hand = new List<Card>();
        // properties of TwentyOneDealer
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
