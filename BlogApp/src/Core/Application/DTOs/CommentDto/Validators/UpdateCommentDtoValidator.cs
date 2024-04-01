namespace Application.DTOs.CommentDto.Validators;
using FluentValidation;

public class UpdateCommentDtoValidator : AbstractValidator<UpdateCommentDto>
{
    public UpdateCommentDtoValidator()
    {
        RuleFor(p => p.Id)
            .NotEmpty().WithMessage("{PropertyName} Id is required.")
            .NotNull().WithMessage("{PropertyName} Id is required.");

        RuleFor(p => p.Content)
            .NotEmpty().WithMessage("{PropertyName} Content is required.")
            .NotNull().WithMessage("{PropertyName} Content is required.");
    }
}