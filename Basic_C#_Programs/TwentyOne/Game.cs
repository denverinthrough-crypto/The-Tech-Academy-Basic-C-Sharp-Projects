using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public abstract class Game // object and abstract 
    {
        public List<Player> Players { get; set; } // properties
        public string Name { get; set; } // properties
        public string Dealer {  get; set; } // properties


        public abstract void Play();


        public virtual void ListPlayers()
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }

        }
    }
}
