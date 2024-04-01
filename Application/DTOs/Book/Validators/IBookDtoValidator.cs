using FluentValidation;

namespace Application.DTOs.Book.Validators;

public class IBookDtoValidator : AbstractValidator<IBookDTO>
{
    public IBookDtoValidator()
    {
        RuleFor(p => p.Title)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(50).WithMessage("{PropertyName} cannot exceed 100 characters.");

        RuleFor(p => p.Genre)
            .NotEmpty().WithMessage("{PropertyName} is required.");

        RuleFor(p => p.Year)
            .NotEmpty().WithMessage("{PropertyName} is required.");

        RuleFor(p => p.Author)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(50).WithMessage("{PropertyName} cannot exceed 50 characters.");

        RuleFor(p => p.Description)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(500).WithMessage("{PropertyName} cannot exceed 500 characters.");
        
        RuleFor(p => p.Language)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .MaximumLength(50).WithMessage("{PropertyName} cannot exceed 50 characters.");
    }

}