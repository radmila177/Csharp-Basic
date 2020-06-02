using MovieStoreLibrary.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreLibrary
{
    public class Movie
    {
        private static int _idGenerator = 0; 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Year { get; set; }
        public MovieGenre Genre { get; set; }
        public int MovieQuantity { get; set; }
        private int Price { get; set; }

        public Movie(){}
        public Movie(string title, string description, DateTime year, MovieGenre genre, int moviequantity)
        {
            _idGenerator++;
            Id = _idGenerator;  
            Title = title;
            Description = description;
            Year = year;
            Genre = genre;
            MovieQuantity = moviequantity;
        }
        public void SetPrice()
        {
            //Random random = new Random();
            if (Year.Year < 2000)
            {
                Price = new Random().Next(100, 200);
            }
            else if (Year.Year > 2000 && Year.Year < 2010)
            {
                Price = new Random().Next(200, 300);
            }
            else
            {
                Price = new Random().Next(300, 500);
            }

        }
         public string MovieInfo()
        {
            return $"{Id}) {Title} - {Genre}, {Year}.";
        }



    }
}
