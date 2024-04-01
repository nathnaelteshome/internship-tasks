using Application.Contracts.Persistence;
using Domain.Entites;
using Domain.Common;

using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests.Mocks;

public static class MockBookRepository
{
    public static Mock<IBookRepository> GetBookRepository()
    {
        var book = new List<Book>{
            new Book
            {
                Id = 1,
                Title = "Book 1",
                Genre = "Genre 1",
                Year = new DateTime(2022, 1, 1, 0, 0, 0, DateTimeKind.Utc)
                Language = "English"
                Author = "Author 2"
            },
            new Book
            {
                Id = 2,
                Title = "Book 2",
                Genre = "Genre 2",
                Year = new DateTime(2021, 2, 15, 0, 0, 0, DateTimeKind.Utc)
                Language = "English"
                Author = "Author 2"
            },
            new Book
            {
                Id = 3,
                Title = "Book 3",
                Genre = "Genre 3",
                Year = new DateTime(2020, 5, 10, 0, 0, 0, DateTimeKind.Utc)
                Language = "English"
                Author = "Author 2"
            },
            new Book
            {
                Id = 4,
                Title = "Book 4",
                Genre = "Genre 4",
                Year = new DateTime(2019, 8, 20, 0, 0, 0, DateTimeKind.Utc)
                Language = "English"
                Author = "Author 2"
            }
        };

        var mockRepo = new Mock<IBookRepository>();

        mockRepo.Setup(r => r.Add(It.IsAny<Book>())).ReturnsAsync((Book Book) =>
        {
            book.Add(Book);
            return Book;
        });


        return mockRepo;

    }
}

