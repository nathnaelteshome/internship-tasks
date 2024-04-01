namespace Application.DTOs.CommentDto.Validators;
using FluentValidation;

public class ListCommentDtoValidator : AbstractValidator<ListCommentDto>
{
    public ListCommentDtoValidator()
    {
        RuleFor(p => p.Content)
            .NotEmpty().WithMessage("{PropertyName} Content is required.")
            .NotNull().WithMessage("{PropertyName} Content is required.");

        RuleFor(p => p.BlogId)
            .NotEmpty().WithMessage("{PropertyName} BlogId is required.")
            .NotNull().WithMessage("{PropertyName} BlogId is required.");
    }
}