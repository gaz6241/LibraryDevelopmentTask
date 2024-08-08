using LibraryDevelopmentTask.Interfaces;

namespace LibraryDevelopmentTask.Data
{
    public class BookRepository : Repository<IBook>, IBookRepository
    {
        private static List<IBook> _books = new();

        public BookRepository() : base(_books)
        {
        }

        public async Task<IBook?> GetByIsbnAsync(string isbn)
        {
            var book = await Task.FromResult(_books.SingleOrDefault(b => b.ISBN == isbn));
            return book;
        }

        public async Task<IBook?> GetByTitleAsync(string title)
        {
            var book = await Task.FromResult(_books.SingleOrDefault(b => b.Title == title));
            return book;
        }

        public async Task<IEnumerable<IBook>> GetByAuthorAsync(string author)
        {
            IEnumerable<IBook> books = await Task.FromResult(_books.Where(b => b.Author == author));
            return books;
        }
    }
}