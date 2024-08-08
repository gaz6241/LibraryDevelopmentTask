namespace LibraryDevelopmentTask.Interfaces
{
    public interface IBook : IDbRecord
    {
        string Title { get; set; }
        string Author { get; set; }
        string ISBN { get; set; }
    }
}