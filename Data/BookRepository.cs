using LibraryDevelopmentTask.Interfaces;
using LibraryDevelopmentTask.Models;

namespace LibraryDevelopmentTask.Data
{
    public class BookRepository : IRepository<Book>
    {
        private readonly List<Book> _books = new();

        public async Task<Book?> GetByIdAsync(string id)
        {
            var book = await Task.FromResult(_books.SingleOrDefault(b => b.ISBN == id));
            return book;
        }

        public async Task<int> AddAsync(Book book)
        {
            _books.Add(book);
            var idx = _books.IndexOf(book);

            return idx + 1;
        }

        public async Task<bool> UpdateAsync(Book book)
        {
            var bookToUpdate = _books.SingleOrDefault(b => b.ISBN == book.ISBN);

            if (bookToUpdate == null)
            {
                return false;
            }

            bookToUpdate = book;
            return true;
        }

        public async Task DeleteAsync(int accountNo)
        {
            throw new NotImplementedException();
        }
    }
}