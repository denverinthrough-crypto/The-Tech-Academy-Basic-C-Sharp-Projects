using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }

        //string[] names = { "Mark", "Dinber", "Denver", "Maekar", "Baelor" };

        //for (int i = 0; i  < names.Length; i++)
        //{

        //    Console.WriteLine(names[i]);

        //}

        //Console.ReadLine();

        //List<int> testScores = new List<int>();

        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(71);
        //testScores.Add(70);

        //foreach (int scores in testScores)
        //{
        //    if (scores > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + scores);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "mark", "denver", "dinber", "maekar", "baelor" };

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //    Console.ReadLine();
        //}

        //List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };

        //List<int> passingScores = new List<int>();

        //foreach(int score in testScores)
        //{
        //    if (score > 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}

        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();


        // ************** ASSIGNEMENT PART 1 *************

        // array of strings
        string[] fruits = { "Apple ", "Banana ", "Cherry ", "Grapes ", "Mango " };

        // User's input text
        Console.WriteLine("Enter some text: ");
        string userText = Console.ReadLine(); // reads full line including spaces

        // loop through each string and append user's text 
        for (int i = 0; i < fruits.Length; i++)
        {
            fruits[i] += userText; // add userText to the end of the string
        }

        // Second loop to print each updated string
        Console.WriteLine("\nUpdated array: ");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i]);
            Console.ReadLine();
        }


        // *************** ASSIGNMENT PART 2 *****************

        // *********** INFINITE LOOP *************

        int counter = 0; // initialize counter to 0
        while (true) // loop starts as infinite
        {
            Console.WriteLine("Loop iteration: " + (counter + 1));
            counter++; // increment counter each interation
            if (counter >= 5) // check if counter reached 5

            {
                break; // break exits the loop completely
            }
        }

        Console.WriteLine("Loop finsihed!");


        
  
        




    }
}