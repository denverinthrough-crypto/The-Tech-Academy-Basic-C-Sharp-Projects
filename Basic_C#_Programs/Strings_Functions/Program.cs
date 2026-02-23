using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFucntions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Dinber";
            //    string quote = "The man said, \"Hello\", Dinber. \n Hello on a new line . \n \t Hello on a tab.";

            //    bool trueOrFalse = name.Contains("s");
            //    trueOrFalse = name.EndsWith("s");

            //    int  length = name.Length;

            //    name = name.ToUpper();

            //    name = name.ToLower();

            //    Console.WriteLine(name);
            //    Console.ReadLine();


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Dinber");



            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}