using FluentValidation;
using MovieStore.Models.Requests;
using System.Linq.Expressions;

namespace MovieStore.Validators
{

    public class AddMovieRequestValitaror : AbstractValidator<AddMovieRequest>
    {
        public AddMovieRequestValitaror() { }
        {
        RuleFor( x => x.Title)
        .NotEmpty
        }
}

