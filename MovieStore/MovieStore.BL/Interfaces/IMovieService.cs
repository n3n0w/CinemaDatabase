﻿using MovieStore.Models.DTO;
using MovieStore.Models.Requests;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        void AddMovie(Movie movie);
        void deleteMovie(int id);
        void UpdateMovie(Movie movieDto);

        Movie GetById(int id);
    }
}
