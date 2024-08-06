using LibraryDevelopmentTask.Models;
using LibraryDevelopmentTask.Models.Enums;
using LibraryDevelopmentTask.Interfaces;
using LibraryDevelopmentTask.Data;

namespace LibraryDevelopmentTask.Services
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _repository;

        public BookService()
        {
            _repository = new BookRepository();
        }
        public async Task<Book?> GetBook(string isbn)
        {
            var book = await _repository.GetByIDAsync(isbn);

            return book;
        }

        public async Task<int> AddBook(string title, string author, string isbn, Category category)
        {
            var factory = GetBookFactory(category);
            var book = factory.AddBook(title, author, isbn);
            return await _repository.AddAsync(book);
        }

        public async Task<bool> UpdateBook(Book book)
        {
            return await _repository.UpdateAsync(book);
        }

        public async Task DeleteBook(string isbn)
        {
            throw new NotImplementedException();
        }

        private IBookFactory GetBookFactory(Category category)
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