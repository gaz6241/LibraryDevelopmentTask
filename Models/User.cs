using LibraryDevelopmentTask.Interfaces;

namespace LibraryDevelopmentTask.Models
{
    public class User : IDbRecord
    {
        private int id;

        public User(string name)
        {
            Name = name;
        }

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string Name { get; set; }
        public List<Transaction> History { get; set; }

       

    }
}