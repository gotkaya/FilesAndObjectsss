﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlesAndObjects
{
    class Program
    {
        class Movie
        {
            public string title;
            public string rating;
            public string year;

            public Movie (string _title, string _rating,string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;
            }
        }
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\opilane\samples";
            string fileName = @"MovieTV.txt";
            List<string> movieList = File.ReadAllLines(Path.Combine(filePath, fileName)).ToList();
            List<Movie> listOfMovies = new List<Movie>();

            foreach (string movieItem in movieList)
            {
                string[] tempArray = movieItem.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                Movie newMovie = new Movie (tempArray[0],tempArray[1], tempArray[2]);
                listOfMovies.Add(newMovie);
                
            }

            foreach(Movie movie in listOfMovies)
            {
                Console.WriteLine($"title:{movie.title}; Rating:{movie.rating}; Year: {movie.year}");
            }
        }
    }
}
