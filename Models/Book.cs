using LibraryDevelopmentTask.Models.Enums;
using LibraryDevelopmentTask.Interfaces;

namespace LibraryDevelopmentTask.Models
{
    public abstract class Book
    {
        private int id;

        public int GetId()
        {
            return id;
        }

        public void SetId(int value)
        {
            id = value;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool NumCopies { get; set; }
        public abstract Category Category { get; }
    }

    public class FictionBook : Book, IBook
    {
        public override Category Category => Category.Fiction;
    }

    public class NonFictionBook : Book, IBook
    {
        public override Category Category => Category.NonFiction;
    }
}
