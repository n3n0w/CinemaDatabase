using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BusinessController : ControllerBase
    {
        private readonly IMovieBlService _movieService;

        public BusinessController(IMovieBlService movieService)
        {
            _movieService = movieService;
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("GetAllMovieWithDetails")]
        public IActionResult GetAllMovieWithDetails()
        {
            var result = _movieService.GetDetailedMovies();

            if (result == null || result.Count == 0)
            {
                return NotFound("No movies found");
            }

            return Ok(result);
        }

       
    }
}
