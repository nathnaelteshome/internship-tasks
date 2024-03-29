namespace Application.DTOs.CommentDto.Validators;

public class CreateCommentDtoValidator : AbstractValidator<CreateCommentDto>
{
    public CreateCommentDtoValidator()
    {
        RuleFor(p => p.Content)
            .NotEmpty().WithMessage("{PropertyName} Content is required.")
            .NotNull().WithMessage("{PropertyName} Content is required.")

        RuleFor(p => p.UserId)
            .NotEmpty().WithMessage("{PropertyName} UserId is required.")
            .NotNull().WithMessage("{PropertyName} UserId is required.")
    }
}