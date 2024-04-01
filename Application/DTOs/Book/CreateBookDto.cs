using Application.DTOs.Common;

namespace Application.DTOs.Book
{
    public class CreateBookDto : BaseDto, IBookDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Language { get; set; }
    }
}