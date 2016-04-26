using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLeran
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeCinemaEntities db=new HomeCinemaEntities();
            var dbSet = db.Movies;
            List<Movie> movies = dbSet.ToList();
            foreach (Movie movie in movies)
            {
                Console.WriteLine(movie.Director);
            }
            Console.Read();
        }
    }
}
