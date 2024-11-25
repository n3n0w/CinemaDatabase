using FluentValidation;
using MovieStore.Models.Requests;
using System.Linq.Expressions;

namespace MovieStore.Validators
{

    public class AddMovieRequestValitaror : AbstractValidator<AddMovieRequest>
    {
        public AddMovieRequestValitaror()
        {
            {
                RuleFor(x => x.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(100)
                .MinimumLength(2);

                RuleFor(x => x.Year)
                    .GreaterThan(1900).WithMessage("Year must be greater than 1900")
                    .LessThan(2100);
            }
        }
    }
}

