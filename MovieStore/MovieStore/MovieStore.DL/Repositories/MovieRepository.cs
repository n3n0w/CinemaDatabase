using MovieStore.DL.StaticDB;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories
{
    [Obsolete]
    internal class MovieStaticRepository 
    {
        public List<Movie> GetAllMovies()
        {
            return InMemoryDb.Movies;
        }

        public void AddMovie(Movie movie)
        {
            if (movie == null) return;

            movie.Id = Guid.NewGuid().ToString();
            InMemoryDb.Movies.Add(movie);
        }

        /// <summary>
        /// Get movie by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Movie? GetMovieById(string id)
        {
           return InMemoryDb.Movies
               .FirstOrDefault(m => m.Id == id);
        }
    }
}
