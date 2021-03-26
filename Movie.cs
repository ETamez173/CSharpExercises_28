using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpExercises_28
{
    class Movie
    {

        public string title;
        public string director;
        // to avoid giving access to the rating we make it private in the movie class
        private string rating;
        // only code within the Movie class can access the rating if a "private" modifier is used


        // this is a contructor where we pass in the title, director, and rating
        // a parameters and the values are assinged to each object 
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        // define getters and setters 
        public string Rating
        {
            get { return rating; }
            set
                // we set up a rule to test if things are equal to the allowed ratings
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}