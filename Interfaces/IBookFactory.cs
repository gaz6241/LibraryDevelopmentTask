using LibraryDevelopmentTask.Models;

namespace LibraryDevelopmentTask
{
    public interface IBookFactory
    {
        Book AddBook(string title, string author, string isbn);
    }
}
