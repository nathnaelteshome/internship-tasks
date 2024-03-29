using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task9.Data;
using Task9.Models;

namespace Task9.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
  private readonly BlogContext _context;

  public PostController(BlogContext context)
  {
    _context = context;
  }

  // GET: api/posts
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Post>>> GetPosts()
  {
    try
    {
      return await _context.Posts.ToListAsync();
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }

  // GET: api/posts/5
  [HttpGet("{id}")]
  public async Task<ActionResult<Post>> GetPost(int id)
  {
    try
    {
      var post = await _context.Posts.FindAsync(id);

      if (post == null)
      {
        return NotFound();
      }

      return post;
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }

  // POST api/posts
  [HttpPost]
  public async Task<ActionResult<Post>> PostPost(Post post)
  {
    try
    {
      _context.Posts.Add(post);
      await _context.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPost), new { id = post.PostId }, post);
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

  // DELETE api/posts/5
  [HttpDelete("{id}")]
  public async Task<IActionResult> DeletePost(int id)
  {
    try
    {
      var post = await _context.Posts.FindAsync(id);

      if (post == null)
      {
        return NotFound();
      }

      _context.Posts.Remove(post);
      await _context.SaveChangesAsync();

      return Ok(post);
    }
    catch (Exception ex)
    {
      // Log the exception here
      return StatusCode(500, "Internal server error");
    }
  }
}