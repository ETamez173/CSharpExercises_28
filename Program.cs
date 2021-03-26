using System;

namespace CSharpExercises_28
{
    class Program
    {
        static void Main(string[] args)
        {

            // getters and setters help to make you data more secure
            // also set rules for types of data that are allowed 

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            // G, PG, PG-13, R, NR 
            avengers.Rating = "Dog Woof";  // results in NR default rating when setter verifies input
            //avengers.Rating = "R";

            // shrek.Rating = "Cat";
            // shrek.Rating = "R";

            // to avoid giving access to the rating we make it private in the movie class
            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);
            Console.ReadLine();
        }
    }
}
