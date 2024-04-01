using FluentValidation;

namespace Application.DTOs.Book.Validators;

public class CreateBookDtoValidator : AbstractValidator<IBookDTO>
{
    public CreateBookDtoValidator()
    {
        Include(new IBookDtoValidator());
    }
}