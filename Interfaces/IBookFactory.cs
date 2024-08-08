namespace LibraryDevelopmentTask.Interfaces
{
    public interface IBookFactory
    {
        IBook AddBook(string title, string author, string isbn);
    }
}
