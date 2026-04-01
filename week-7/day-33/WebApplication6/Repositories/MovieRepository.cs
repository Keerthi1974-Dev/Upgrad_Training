using WebApplication6.Models;

namespace WebApplication6.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        static List<Movie> movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010,7,16), Price = 500, Rating = "8" },
            new Movie { Id = 2, Title = "Titanic", Genre = "Romance", ReleaseDate = new DateTime(1997,12,19), Price = 400, Rating = "9" }
        };

        public List<Movie> GetAll() => movies;

        public Movie GetById(int id) => movies.FirstOrDefault(m => m.Id == id);

        public void Add(Movie movie)
        {
            movie.Id = movies.Max(m => m.Id) + 1;
            movies.Add(movie);
        }

        public void Update(Movie movie)
        {
            var existing = movies.FirstOrDefault(m => m.Id == movie.Id);
            if (existing != null)
            {
                existing.Title = movie.Title;
                existing.Genre = movie.Genre;
                existing.ReleaseDate = movie.ReleaseDate;
                existing.Price = movie.Price;
                existing.Rating = movie.Rating;
            }
        }

        public void Delete(int id)
        {
            var movie = movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                movies.Remove(movie);
            }
        }
    }
}