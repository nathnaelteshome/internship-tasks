using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task9.Data;
using Task9.Models;

using FluentValidation;

namespace Task9.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CommentController : ControllerBase
  {
    private readonly BlogContext _context;
    private readonly IValidator<Comment> _validator;

    public CommentController(BlogContext context, IValidator<Comment> validator)
    {
      _context = context;
      _validator = validator;
    }

    // POST api/comments
    [HttpPost]
    public async Task<ActionResult<Comment>> PostComment(Comment comment)
    {
      try
      {
        var validationResult = _validator.Validate(comment);
        if (!validationResult.IsValid)
        {
          return BadRequest(validationResult.Errors);
        }

        _context.Comments.Add(comment);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(Comment), new { id = comment.CommentId }, comment);
      }
      catch (Exception ex)
      {
        // Log the exception here
        return StatusCode(500, "Internal server error");
      }
    }

    // PUT api/comments/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutComment(int id, Comment comment)
    {
      try
      {
        if (id != comment.CommentId)
        {
          return BadRequest();
        }

        var validationResult = _validator.Validate(comment);
        if (!validationResult.IsValid)
        {
          return BadRequest(validationResult.Errors);
        }

        _context.Entry(comment).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return Ok(await _context.Comments.FindAsync(id));
      }
      catch (Exception ex)
      {
        // Log the exception here
        return StatusCode(500, "Internal server error");
      }
    }

  }
}
