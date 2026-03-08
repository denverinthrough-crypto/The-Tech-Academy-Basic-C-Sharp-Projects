using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne // Base Class
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public override void Play() // method or function
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
