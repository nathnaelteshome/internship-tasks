using FluentValidation;

namespace Application.DTOs.Book.Validators;

public class UpdateBookDtoValidator : AbstractValidator<IBookDTO>
{
    public UpdateBookDtoValidator()
    {
        Include(new IBookDtoValidator());
    }
}