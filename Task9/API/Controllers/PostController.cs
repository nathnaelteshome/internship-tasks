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

  // Existing code...

  // GET api/posts/comments/5
  [HttpGet("comments/{id}")]
  public async Task<ActionResult<Comment>> GetComment(int id)
  {
    var comment = await _context.Comments.FindAsync(id);

    if (comment == null)
    {
      return NotFound();
    }

    return comment;
  }


}

