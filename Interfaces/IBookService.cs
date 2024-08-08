using LibraryDevelopmentTask.Models.Enums;

namespace LibraryDevelopmentTask.Interfaces
{
    public interface IBookService
    {
        Task<int> AddBook(string title, string author, string isbn, Category category);
        Task<IBook?> GetBookById(int id);
        Task<IBook?> GetBookByIsbn(string isbn);
        Task<bool> UpdateBook(IBook book);
        Task DeleteBook(string isbn);
    }
}