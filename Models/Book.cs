namespace LibraryDevelopmentTask.Models
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool NumCopies { get; set; }
        public abstract string Category { get; }
    }

    public class FictionBook : Book
    {
        public override string Category => "Fiction";
    }

    public class NonFictionBook : Book
    {
        public override string Category => "Non-Fiction";
    }
}
