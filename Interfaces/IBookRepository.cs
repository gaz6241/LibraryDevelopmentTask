namespace LibraryDevelopmentTask.Interfaces
{
    public interface IBookRepository: IRepository<IBook>
    {
        Task<IBook?> GetByIsbnAsync(string isbn);
        Task<IEnumerable<IBook>> GetByAuthorAsync(string author);
        Task<IBook?> GetByTitleAsync(string title);
    }
}