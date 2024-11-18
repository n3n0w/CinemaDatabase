using MovieStore.DL.Interfaces;
using MovieStore.DL.StaticDB;
using MovieStore.Models.DTO;
using MovieStore.Models.Requests;

namespace MovieStore.DL.Repositories
{
    internal class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAllMovies()
        {
            return InMemoryDb.Movies;
        }

        public void AddMovie(Movie movie)
        {
            InMemoryDb.Movies.Add(movie);
        }

        public Movie? GetMovieById(int id)
        {
           return InMemoryDb.Movies
               .FirstOrDefault(m => m.Id == id);
        }
    }
}
