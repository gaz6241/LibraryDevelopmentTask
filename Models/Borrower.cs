﻿namespace LibraryDevelopmentTask.Models
{
    public class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Transaction> History { get; set; }
    }
}
