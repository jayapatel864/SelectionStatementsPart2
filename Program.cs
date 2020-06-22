using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            Console.WriteLine("Guess a number between 1 and 1000");
            var i = r.Next(1, 1000);
            var x = int.Parse(Console.ReadLine());
            //Console.WriteLine("i = " + i);
            //Console.WriteLine("x = " + x);
            if (i > x)
            {
                Console.WriteLine("Too low ");

            }
            else if (i < x)
            {
                Console.WriteLine("Too high");

            }
            else
            {
                Console.WriteLine("Nevermind");


            }





        }
    }
}
