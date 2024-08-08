namespace LibraryDevelopmentTask.Interfaces
{
    public interface IRepository<T>
    {
        Task<T?> GetByIdAsync(int id);
        Task<int> AddAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task DeleteAsync(int id);
    }
}
