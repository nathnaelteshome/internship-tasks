using Task9.Data;
using Task9.Models;

namespace Services;

public class PostManager{

    private readonly BlogContext _context;

    public PostManager(BlogContext context){
        _context = context;
    }

    // Create a post
    public Post CreatePost(Post post){
        _context.Posts.Add(post);
        _context.SaveChanges();
        return post;
    }

    //Update a post using the id but throws exception if it doesnt exist
    public Post UpdatePost(Post UpdatedPost){
        Post old = GetPostById(UpdatedPost.PostId) ?? throw new Exception("Post not found");
        old.Title = UpdatedPost.Title;
        old.Content = UpdatedPost.Content;
        _context.SaveChanges();
        return old;
    }

    //Delete a post with id or throw exception
    public void DeletePost(int id){
        Post post = GetPostById(id) ?? throw new Exception("Post not found");
        _context.Posts.Remove(post);
        _context.SaveChanges();
    }

    // get all the posts
    public List<Post> GetAllPosts(){
        return _context.Posts.ToList();
    }

    // get a post with id
    public Post GetPostById(int id){
        Post post = _context.Posts.Find(id) ?? throw new Exception("Post not found");
        return post; 
    }
}