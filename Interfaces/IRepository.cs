using LibraryDevelopmentTask.Models;

namespace LibraryDevelopmentTask.Interfaces
{
    internal interface IRepository<T>
    {
        Task<Book?> GetByIdAsync(string id);
        Task<int> AddAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task DeleteAsync(int id);
    }
}
