using LibraryDevelopmentTask.Models;
using LibraryDevelopmentTask.Models.Enums;

namespace LibraryDevelopmentTask.Interfaces
{
    public interface IBookService
    {
        Task<int> AddBook(string title, string author, string isbn, Category category);
        Task<Book?> GetBook(string id);
        Task<bool> UpdateBook(Book book);
        Task DeleteBook(string isbn);
    }
}