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

            Console.WriteLine("Welcom to the Grand Hotel and Casino. Let's start by telling me your name. ");
            string playerName = Console.ReadLine(); // user's name input

            Console.WriteLine("And how much money did you bring today? ");
            int bank = Convert.ToInt32(Console.ReadLine()); // convert string to integer - output always in a string

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") // if yes execute while to play
            {
                Player player = new Player(playerName, bank); // create "player" object
                Game game = new TwentyOneGame(); // polymorphism and an object "game"
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0) // conditions
                {
                    game.Play(); // Play method call function
                }
                game -= player;
                Console.WriteLine("Thank you for playing. Comeback next time. ");


            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();






            
        }

        

       



    }
}