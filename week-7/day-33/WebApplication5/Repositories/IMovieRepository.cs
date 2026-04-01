using WebApplication5.Models;

namespace WebApplication5.Repositories
{
    public interface IMovieRepository
    {
          List<Movie> GetAll();
            Movie GetById(int id);
            void Add(Movie movie);
            void Update(Movie movie);
            void Delete(int id);
        }


    }
}
