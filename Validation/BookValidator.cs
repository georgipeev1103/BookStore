using FluentValidation;
using BookStore.Models;

namespace BookStore.Validation
{
    public class BookValidator : AbstractValidator<BookDto>
    {
        public BookValidator()
        {
            RuleFor(b => b.Title).NotEmpty().WithMessage("Book title is required.");
        }
    }
}

