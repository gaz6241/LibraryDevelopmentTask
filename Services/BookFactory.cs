using LibraryDevelopmentTask.Models;

namespace LibraryDevelopmentTask.Services
{
    public class FictionBookFactory : IBookFactory
    {
        public Book AddBook(string title, string author, string isbn)
        {
            return new FictionBook { Title = title, Author = author, ISBN = isbn };
        }
    }

    public class NonFictionBookFactory : IBookFactory
    {
        public Book AddBook(string title, string author, string isbn)
        {
            return new NonFictionBook { Title = title, Author = author, ISBN = isbn };
        }
    }
}