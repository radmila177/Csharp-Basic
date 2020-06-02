using MovieStoreLibrary;
using MovieStoreLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreServices
{
    public class MovieService
    {
        public List<Movie> Movies { get; set; }

        public MovieService()
        {
            Movies = new List<Movie>
            {
                 new Movie("The Invisible Man","Thriller", new DateTime (2020, 5, 6), MovieGenre.Horor,3),
                 new Movie("Fonzo","Crime",  new DateTime (2020, 12, 4), MovieGenre.Drama,5),
                 new Movie("The Lovebirds","Romance", new DateTime (2020, 3, 3), MovieGenre.Comedy,4),
                 new Movie("Parasite","Thriller",  new DateTime (2020, 10, 7), MovieGenre.Comedy,2),
            };
        }
        public void PrintMovies()
        {
            Console.WriteLine("Movie:");
            foreach (Movie movie in Movies)
            {
                Console.WriteLine(movie.MovieInfo());
            }

        }

        List<Movie> rentedMovie = new List<Movie>();
        public void MovieForRent()
        {
            Console.WriteLine("Movies for renting:");
            PrintMovies();

            Console.WriteLine("Input the title of the movie you like to rent:");
            string TitleForRent = Console.ReadLine();
           
            bool incorrectInput = false;


            foreach (Movie movie in Movies)
            {
                if (movie.Title == TitleForRent)
                {
                    if (movie.MovieQuantity >= 1)
                    {
                        rentedMovie.Add(movie);
                        movie.MovieQuantity--;
                        Console.WriteLine($"Thank you for renting {TitleForRent}");

                    }
                    else if (incorrectInput == true)
                    {
                        Console.WriteLine($"No results to show with {TitleForRent}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, movie is already rented.");
                    }
                }


            }

        }
        public void MyRentedMovies()
        {
            rentedMovie.ForEach(movie =>Console.WriteLine(movie.MovieInfo()));
            if (rentedMovie.Count == 0)
            {
                Console.WriteLine("There are no movies yet!");
                return;
            }
        }
    }
}
    



    

