using System.Linq;
using System;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            var movies = context.Videos;

            //----- EXERCISE 1
            //var query = movies.Where(m => m.Genre.Name == "action").OrderBy(m => m.Name).Select(m => m);

            //foreach(var m in query)
            //{
            //    Console.WriteLine(m.Name);
            //}

            //----- EXERCISE 2
            //var query = movies.Where(m => m.Genre.Name == "drama" && m.Classification == Classification.Gold).OrderByDescending(m => m.ReleaseDate);

            //foreach(var m in query)
            //{
            //    Console.WriteLine(m.Name);
            //}

            //----- EXERCISE 3
            //var query = movies.Select(m => new { MovieName = m.Name, Genre = m.Genre.Name });

            //foreach(var m in query)
            //{
            //    Console.WriteLine(m.MovieName + "\t\t" + m.Genre);
            //}

            //----- EXERCISE 4
            //var groups = movies
            //    .GroupBy(m => m.Classification)
            //    .Select(g => new
            //    {
            //        Classification = g.Key.ToString(),
            //        Movies = g.OrderBy(v => v.Name)
            //    });

            //foreach(var g in groups)
            //{
            //    Console.WriteLine(g.Classification);
            //    foreach(var m in g.Movies)
            //    {
            //        Console.WriteLine("\t" + m.Name);
            //    }
            //}

            //-----EXERCISE 5
            //var groups = movies
            //    .GroupBy(m => m.Classification)
            //    .Select(g => new
            //    {
            //        Classification = g.Key.ToString(),
            //        MovieCount = g.Count()
            //    })
            //    .OrderBy(g => g.Classification);

            //foreach(var g in groups)
            //{
            //    Console.WriteLine(g.Classification + " - " + g.MovieCount);
            //}


            //----- EXERCISE 6
            //var query = context.Genres
            //    .Select(g => new
            //    {
            //        Genre = g.Name,
            //        VideoCount = g.Videos.Count()
            //    })
            //    .OrderByDescending(g => g.VideoCount);

            //foreach(var g in query)
            //{
            //    Console.WriteLine("{0} ({1})", g.Genre, g.VideoCount);
            //}

            Console.ReadKey();
        }
    }
}
