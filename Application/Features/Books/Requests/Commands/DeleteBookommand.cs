using MediatR;
using Application.Responses;

namespace Application.Features.Movies.Requests.Commands;

public class DeleteBookCommand : IRequest<BaseCommandResponse>
{
    public int Id { get; set; }
}
