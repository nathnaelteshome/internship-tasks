using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task9.Data;
using Task9.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Task9.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommentController : ControllerBase
{
  private readonly BlogContext _context;

  public CommentController(BlogContext context)
  {
    _context = context;
  }

  // GET: api/comments
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Comment>>> GetComments()
  {
    try
    {
      return await _context.Comments.ToListAsync();
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }

  // GET: api/comments/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Comment>> GetComment(int id)
  {
    try
    {
      var comment = await _context.Comments.FindAsync(id);

      if (comment == null)
      {
        return NotFound();
      }

      return comment;
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }

  // POST api/comments
  [HttpPost]
  public async Task<ActionResult<Comment>> PostComment(Comment comment)
  {
    try
    {
      _context.Comments.Add(comment);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetComment), new { id = comment.CommentId }, comment);
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

  // DELETE api/comments/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteComment(int id)
  {
    try
    {
      var comment = await _context.Comments.FindAsync(id);

      if (comment == null)
      {
        return NotFound();
      }

      _context.Comments.Remove(comment);
      await _context.SaveChangesAsync();

      return Ok(comment);
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }
}
