using LibraryDevelopmentTask.Data;
using LibraryDevelopmentTask.Interfaces;
using LibraryDevelopmentTask.Models.Enums;

namespace LibraryDevelopmentTask.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repository;

        public BookService()
        {
            _repository = new BookRepository();
        }

        public async Task<IBook?> GetBookById(int id)
        {
            var book = await _repository.GetByIdAsync(id);

            return book;
        }

        public async Task<IBook?> GetBookByIsbn(string isbn)
        {
            var book = await _repository.GetByIsbnAsync(isbn);

            return book;
        }

        public async Task<int> AddBook(string title, string author, string isbn, Category category)
        {
            var factory = GetBookFactory(category);
            var book = factory.AddBook(title, author, isbn);
            return await _repository.AddAsync(book);
        }

        public async Task<bool> UpdateBook(IBook book)
        {
            return await _repository.UpdateAsync(book);
        }

        public async Task DeleteBook(string isbn)
        {
            throw new NotImplementedException();
        }

        private static IBookFactory GetBookFactory(Category category)
        {
            IBookFactory factory;

            switch (category)
            {
                case Category.Fiction:
                    factory = new FictionBookFactory();
                    break;
                case Category.NonFiction:
                    factory = new NonFictionBookFactory();
                    break;
                default:
                    throw new NotImplementedException();
            }

            return factory;
        }
    }
}