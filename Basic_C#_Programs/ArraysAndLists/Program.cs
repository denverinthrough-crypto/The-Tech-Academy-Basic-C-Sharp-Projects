using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] players = { "Kobe", "Dirk", "KG", "Tim", "Iverson" };

        for (int i = 0; i < players.Length; i++)
        {
            Console.Write(players[i]);

            if (i < players.Length - 1)
                Console.Write(", ");
        }

        Console.ReadLine();

        Console.WriteLine();


        Console.WriteLine("Pick your favorite player choose between 0 to 4: ");
        int playerSelect = Convert.ToInt32(Console.ReadLine());
        

        if (playerSelect >= 0 && playerSelect < players.Length )
        {
            Console.WriteLine("You Select favorite player: " + players[playerSelect]);
        } else
        {
            Console.WriteLine("You pick invalid index number!");
        }

        Console.ReadLine();

        Console.WriteLine();

        int[] jerseys = { 24, 41, 5, 21, 3 };

        Console.WriteLine(string.Join(", ", jerseys));

        Console.ReadLine();
        Console.WriteLine("Pick your favorite jersey numbers, choose between 0 to 4: ");
        int jerseySelect = Convert.ToInt32(Console.ReadLine());

        if (jerseySelect >= 0 && jerseySelect < jerseys.Length )
        {
            Console.WriteLine("You select favorite jersey number: " + jerseys[jerseySelect]);
        } else
        {
            Console.WriteLine("You pick invalid index number!");
        }

        Console.ReadLine();

        Console.WriteLine();

        List<string> names = new List<string>();
        {

            names.Add("Denver");
            names.Add("Dinber");
            names.Add("Mark");
            names.Add("Maekar");
            names.Add("Baelor");

        };

        Console.WriteLine(string.Join(", ", names));
        Console.ReadLine(); 
        Console.WriteLine("Pick the name you like, from 0 to 4: ");
        int nameSelect = Convert.ToInt32(Console.ReadLine());

        switch (nameSelect)
        {
            case 0:
                Console.WriteLine("You pick name: " + names[nameSelect]);
                break;

            case 1:
                Console.WriteLine("You pick name: " + names[nameSelect]);
                break;

            case 2:
                Console.WriteLine("You pick name: " + names[nameSelect]);
                break;

            case 3:
                Console.WriteLine("You pick name: " + names[nameSelect]);
                break;

            case 4:
                Console.WriteLine("You pick name: " + names[nameSelect]);
                break;
            default:
                Console.WriteLine("Invalide index number!");
                break;
        }















        //List<int> intList = new List<int>();

        //intList.Add(5);
        //intList.Add(10);
        //intList.Remove(10);


        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //List<string> names = new List<string>();

        //names.Add("mark");
        //names.Add("denver");
        //names.Add("ei");

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);

        //}

        //Console.WriteLine();

        //names[2] = "dinber";

        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}



        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000,600, 2300 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();


    }
}

