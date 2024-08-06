using LibraryDevelopmentTask.Models.Enums;

namespace LibraryDevelopmentTask.Models
{
    public class Transaction
    {
        public DateTime Created { get; set; }
        public TransactionType Type { get; set; }
        public string ISBN { get; set; }
        public int BorrowerId { get; set; }
    }
}