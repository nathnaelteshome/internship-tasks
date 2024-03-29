using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task9.Data;
using Task9.Models;
using FluentValidation;

namespace Task9.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
  private readonly BlogContext _context;
  private readonly IValidator<Post> _validator;

  public PostController(BlogContext context, IValidator<Post> validator)
  {
    _context = context;
    _validator = validator;
  }

  // POST api/posts
  [HttpPost]
  public async Task<ActionResult<Post>> PostPost(Post post)
  {
    try
    {
      var validationResult = _validator.Validate(post);

      if (!validationResult.IsValid)
      {
        return BadRequest(validationResult.Errors);
      }

      _context.Posts.Add(post);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(Post), new { id = post.PostId }, post);
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }

  // PUT api/posts/5
  [HttpPut("{id}")]
  public async Task<IActionResult> PutPost(int id, Post post)
  {
    try
    {
      var validationResult = _validator.Validate(post);

      if (!validationResult.IsValid)
      {
        return BadRequest(validationResult.Errors);
      }

      if (id != post.PostId)
      {
        return BadRequest();
      }

      _context.Entry(post).State = EntityState.Modified;
      await _context.SaveChangesAsync();

      return Ok(await _context.Posts.FindAsync(id));
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }


}