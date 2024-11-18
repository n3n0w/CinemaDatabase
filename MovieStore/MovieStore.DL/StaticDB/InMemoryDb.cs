using MovieStore.Models.DTO;
using MovieStore.Models.Requests;

namespace MovieStore.DL.StaticDB
{
    internal static class InMemoryDb
    {
        public static List<Movie> Movies = new List<Movie>
        {
            new Movie
            {
                Id = 1,
                Title = "The Shawshank Redemption",
                Year = 1994
            },
            new Movie
            {
                Id = 2,
                Title = "The Godfather",
                Year = 1972
            },
            new Movie
            {
                Id = 3,
                Title = "The Dark Knight",
                Year = 2008
            },
        };
    }
}