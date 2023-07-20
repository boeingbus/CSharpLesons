using System;

namespace Hello.World
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            //Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

            /* var table = string.Format("{0, 10} {1,10}", "test", "2");
            var dollarFormat = string.Format("{0:C}",2);

            Console.WriteLine(table);
            Console.WriteLine(dollarFormat);
            */
            //ask the user a question
            Console.WriteLine("What is yur favorite number?");
            string fav;
            fav = Console.ReadLine();
            string response ="your fav number is: " + fav + " Hooray";
            Console.WriteLine(response);

            string response2 = $"interpolation string - Your fav number is: {fav}";
            Console.WriteLine(response2);

        }
    }
}
