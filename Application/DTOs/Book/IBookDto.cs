namespace Application.DTOs.Book;

public interface IBookDTO
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public string Language { get; set; }
}