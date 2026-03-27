using System;
using System.Collections.Generic;
using System.Text;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            // Instantiates and creating a dictionary with their values
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1

        };

        // method
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // lambda expressions
            int[] result = new int[aceCount + 1]; // list of array
            int value = Hand.Sum(x => _cardValues[x.Face]); // lambda expressions
            result[0] = value;
            if (result.Length == 1) // shorthand return result;
            {
                return result;
            }
            for (int i = 1; i < result.Length; i++) // int i = 1; -> result[0]
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
                                    


        }

        // method
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); // integer array
            int value = possibleValues.Max(); // lambda expression
            if (value == 21) return true;
            else return false;
        }

        // method
        public static bool isBusted(List<Card> Hand) // passing a list card
        {
            int value = GetAllPossibleHandValues(Hand).Min(); // lambda expression
            if (value > 21) return true;
            else; return false;
        }

        // method
        public static bool ShouldDealerStay(List<Card> Hand) // parameters
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value  in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        // method return a nullable boolean
        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand) // parameters
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); // lambda expression filter
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            if (playerScore < dealerScore) return false;
            else return null;
        }

    }
}
