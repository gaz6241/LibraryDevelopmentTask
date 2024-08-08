using LibraryDevelopmentTask.Interfaces;

namespace LibraryDevelopmentTask.Data
{
    public class Repository<T> : IRepository<T> where T : IDbRecord
    {
        private readonly List<T> _db;

        public Repository(List<T> items)
        {
            _db = items;
        }

        public async Task<int> AddAsync(T item)
        {
            var id = _db.Count + 1;  //TODO: change to Guid
            item.SetId(id);
            _db.Add(item);
            return id;
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return _db.SingleOrDefault(x => x.GetId() == id);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
