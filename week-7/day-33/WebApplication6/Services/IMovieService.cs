using WebApplication6.Models;

namespace WebApplication6.Services
{
    public interface IMovieService
    {
        List<Movie> GetMovies();
        Movie GetMovie(int id);
        void AddMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int id);
    }
}