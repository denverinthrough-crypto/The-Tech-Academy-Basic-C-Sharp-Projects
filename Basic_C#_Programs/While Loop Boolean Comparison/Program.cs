using System;


class Program
{
    static void Main()
    {
        // ------ WHILE LOOP BOOLEAN COMPARISON -----
        // Initialize a counter variable

        int countWhile = 0;

        // Boolean variable to control the loop
        bool keepRunningWhile = true;

        // WHILE  loop checks the condition BEFORE executing the block
        while (keepRunningWhile)
        {
            Console.WriteLine("WHILE LOOP Iteration: " + countWhile);

            // Increment counter
            countWhile++;

            // Check if count has reached 5, then stop the loop
            if (countWhile >= 5)
            {
                keepRunningWhile = false; // Boolean comparison to stop loop

            }


        }

        Console.WriteLine(); // Blank line for separation

        // ----------- DO-WHILE LOOP BOOLEAN COMPARISON ----------
        // Initialize a counter variable
        int countDoWhile = 0;

        // Boolean variable to control the loop
        bool keepRunningDoWhile;

        // DO-WHILE loop executes the block FIRST, then checks the condition

        do
        {
            Console.WriteLine("DO-WHILE LOOP Iteration: " + countDoWhile);

            // Increment counter
            countDoWhile++;

            // Boolean comparison: loop continues while count is less than 5
            keepRunningDoWhile = (countDoWhile < 5);

        } while (keepRunningDoWhile);

        Console.WriteLine("\nAll loops completed. Press any key to exit. ");
        Console.ReadKey(); // Waits for user input before closing
    }

}