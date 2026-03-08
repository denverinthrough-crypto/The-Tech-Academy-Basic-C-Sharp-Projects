using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game // object
    {
        public List<string> Players { get; set; } // properties
        public string Name { get; set; } // properties
        public string Dealer {  get; set; } // properties


        public abstract void Play();


        public virtual void ListPlayers()
        {
            foreach(string player in Players)
            {
                Console.WriteLine(player);
            }
             
        }
    }
}
