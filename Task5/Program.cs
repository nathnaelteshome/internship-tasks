Library mainLibrary = new Library("Abrehot", "4Killo");

mainLibrary.AddBook(new Book("book1", "author1", "1", 2000));
mainLibrary.AddBook(new Book("book2", "author2", "2", 2001));
mainLibrary.AddMediaItem(new MediaItem("Film1", "CD", 1));
mainLibrary.AddMediaItem(new MediaItem("Film2", "CD", 2));

mainLibrary.PrintCatalog();

public class Library
{
    // inializing variables
    public string Name;
    public string Address;
    public List<Book> Books;

    public List<MediaItem> MediaItems;

    // constructor function
    public Library(string name, string address)
    {
        Name = name;
        Address = address;
        Books = new List<Book>();
        MediaItems = new List<MediaItem>();
    }

    // method for adding Books
    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    // method for removing Books
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }

    // Method for adding item in mediaItem
    public void AddMediaItem(MediaItem item)
    {
        MediaItems.Add(item);
    }

    // Method for removing item in mediaItem
    public void RemoveMeidaItem(MediaItem item)
    {
        MediaItems.Remove(item);
    }

    public void PrintCatalog()
    {
        // check if books are not null and list books
        if (Books.Count == 0)
        {
            Console.WriteLine("There is no books currently!");
        }
        else
        {
            Console.WriteLine("List of Books");
            foreach (Book book in Books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN},Year: {book.Year}");
            }
        }
        // check if mediaItems are not null and list mediaItem
        if (MediaItems.Count == 0)
        {
            Console.WriteLine("There is no media to display currently!");
        }
        else
        {
            Console.WriteLine("List of MediaItems");
            foreach (MediaItem item in MediaItems)
            {
                Console.WriteLine($"Title: {item.Title}, Author: {item.Mediatype}, Duration: {item.Duration}");
            }
        }
    }

}

// creating a class: Book
public class Book
{
    public string Title;
    public string Author;
    public string ISBN;

    public int Year;

    public Book(string title, string author, string isbn, int year)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        Year = year;
    }
}

// create a class MediaItem
public class MediaItem
{
    public string Title;
    public string Mediatype;
    public int Duration;

    public MediaItem(string title, string mediaType, int duration)
    {
        Title = title;
        Mediatype = mediaType;
        Duration = duration;
    }
}

