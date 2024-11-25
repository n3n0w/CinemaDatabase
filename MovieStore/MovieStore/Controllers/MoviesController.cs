using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.Requests;
using System.Net;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;

        public MoviesController(IMovieService movieService, IMapper mapper)
        {
            _movieService = movieService;
            _mapper = mapper;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _movieService.GetAllMovies();

            if (result == null || result.Count == 0)
            {
                return NotFound("No movies found");
            }
        }


        [HttpGet("GetById")]
        [ProducesResponseType<Movie>(StatusCode.Status200OK)]
        [ProducesResponseType<Movie>(StatusCode.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest("Id must be greater than 0");
            }

            var result = _movieService.GetById(id);

            if (result == null)
            {
                return NotFound($"Movie with ID:{id} not fount");
            }
        }

        [HttpPost("Add")]
        public IActionResult Add(AddMovieRequest movie)
        {
            try
            {
                var movieDTO = _mapper.Map<Movie>(movie);

                if (movieDTO == null) {
                    return BadRequest("Can`t convert movie");
                }
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
            [HttpDelete("Delete")]
            public IActionResult Delete(int id)
            {
                if (id == 0)
                {
                    return BadRequest("Id must be greater than 0");
                }
            }
        }
    }
}
