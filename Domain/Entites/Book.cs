using Domain.Common;

namespace Domain.Entities;

public class Book : BaseDomainEntity
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string Genre { get; set; }
    public string Description { get; set; }
    public string Language { get; set; }
}

public class BookSearchCriteria
{
    public string Title { get; set; }
}

