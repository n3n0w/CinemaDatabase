using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieStore.DL.Interfaces;
using MovieStore.Models.Configurations;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Repositories.MongoRepositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly IMongoCollection<Movie> _movies;
        private readonly ILogger<MovieRepository> _logger;

        public MovieRepository(
            IOptionsMonitor<MongoDbConfiguration> mongoConfig,
            ILogger<MovieRepository> logger)
        {
            _logger = logger;
            var client = new MongoClient(
                mongoConfig.CurrentValue.ConnectionString);

            var database = client.GetDatabase(
                mongoConfig.CurrentValue.DatabaseName);

            _movies = database.GetCollection<Movie>(
                mongoConfig.CurrentValue.DatabaseName);
        }

        public List<Movie> GetAllMovies()
        {
           return _movies.Find(movie => true).ToList();
        }

        public void AddMovie(Movie movie)
        {
            if (movie == null)
            {
                _logger.LogError("Movie is null");
                return;
            }

            try
            {
                movie.Id = Guid.NewGuid().ToString();

                _movies.InsertOne(movie);
            }
            catch (Exception e)
            {
               _logger.LogError(e,
                   $"Error adding movie {e.Message}-{e.StackTrace}");
            }
           
        }

        public Movie? GetMovieById(string id)
        {
            if(string.IsNullOrEmpty(id)) return null;

            return _movies.Find(m => m.Id == id)
                .FirstOrDefault();
        }
    }
}
