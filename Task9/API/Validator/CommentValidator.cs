using FluentValidation;
using Task9.Models;

namespace API.Validator;

public class CommentValidator : AbstractValidator<Comment>
{
    public CommentValidator()
    {
        RuleFor(x => x.Text).NotEmpty().WithMessage("Text is required");
    }
}