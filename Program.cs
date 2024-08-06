using LibraryDevelopmentTask.Interfaces;
using LibraryDevelopmentTask.Models.Enums;
using LibraryDevelopmentTask.Services;

namespace LibraryDevelopmentTask
{
    internal class Program
    {
        private static readonly IBookService _bookService = new BookService();
        //private static readonly IUserService _userService = new UserService();

        static async Task Main(string[] args)
        {
            bool userLoggedIn = true;

            while (userLoggedIn)
            {
                Console.WriteLine("\nBook menu");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Update book");
                Console.WriteLine("3. Delete book");
                Console.WriteLine("99. Exit");
                Console.Write("\nEnter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await AddBook();
                        break;
                    case "2":
                        await UpdateBook();
                        break;
                    case "3":
                        await DeleteBook();
                        break;
                    case "99":
                        userLoggedIn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static async Task AddBook()
        {
            try
            {
                Console.Write("ISBN: ");
                var isbn = Console.ReadLine();
                Console.Write("Title: ");
                var title = Console.ReadLine();
                Console.Write("Author: ");
                var author = Console.ReadLine();
                Console.Write("Category: 0) Fiction 1) Non-Fiction ");
                var category = Console.ReadLine();
                
                //todo:validate input

                if (!int.TryParse(category, out int value))
                {
                    Console.WriteLine("Invalid category");
                    return;
                }

                var id = await _bookService.AddBook(title, author, isbn, (Category)value);
                
                Console.WriteLine("Book added successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Toast message");
                //log ex.ToString()
            }
        }

        private static async Task DeleteBook()
        {
            throw new NotImplementedException();
        }

        private static async Task UpdateBook()
        {
            throw new NotImplementedException();
        }
    }
}
