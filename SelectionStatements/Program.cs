using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //var r = new Random();
            //Console.WriteLine("Guess a number between 1 and 1000");
            //var i = r.Next(1, 1000);
            //var x = int.Parse(Console.ReadLine());
            ////Console.WriteLine("i = " + i);
            ////Console.WriteLine("x = " + x);
            //if (i > x)
            //{
            //    Console.WriteLine("Too low ");

            //}
            //else if (i < x)
            //{
            //    Console.WriteLine("Too high");

            //}
            //else
            //{
            //    Console.WriteLine("Nevermind");


            //}


            Console.WriteLine("Input favorite school subject");
            string subject = Console.ReadLine();


            switch (subject)
            {
                case "English":
                    Console.WriteLine("You chose English");


                    break;
                case "Math":
                    Console.WriteLine("You chose Math");

                    break;

                case "Latin":
                    Console.WriteLine("You chose Latin");

                    break;
                case "History":
                    Console.WriteLine("You chose History");

                    break;
                case "Lunch":
                    Console.WriteLine("You chose Lunch");

                    break;
                default:
                    Console.WriteLine("You chose another subject");


                    break;


            }






        }
    }
}
