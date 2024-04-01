using Application.DTOs.Book;
using Application.Features.Books.Requests.Queries;
using Application.Features.Movies.Requests.Commands;
using Application.Features.Movies.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IMediator _mediator;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public BooksController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
    {
        _mediator = mediator;
        this._httpContextAccessor = httpContextAccessor;
    }

    // GET: api/<BooksController>
    [HttpGet]
    public async Task<ActionResult<List<BookDto>>> GetAll()
    {
        var Books = await _mediator.Send(new GetBookListRequest());
        return Ok(Books);
    }


    // GET api/<BooksController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<BookDto>> Get(int id)
    {
        var Book = await _mediator.Send(new GetBookRequest  { Id = id });
        return Ok(Book);
    }

    // POST api/<BooksController>
    [HttpPost]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public async Task<ActionResult<BaseCommandResponse>> Book([FromBody] CreateBookDto Book)
    {
        var user = _httpContextAccessor.HttpContext.User;
        var command = new CreateBookCommand { BookDto = Book };
        var response = await _mediator.Send(command);
        return Ok(response);
    }

    // PUT api/<BooksController>
    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Put([FromBody] UpdateBookDto Book)
    {
        var command = new UpdateBookCommand { BookDto = Book };
        await _mediator.Send(command);
        return NoContent();
    }

    // DELETE api/<BooksController>/5
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<ActionResult> Delete(int id)
    {
        var command = new DeleteBookCommand { Id = id };
        await _mediator.Send(command);
        return NoContent();
    }
}
