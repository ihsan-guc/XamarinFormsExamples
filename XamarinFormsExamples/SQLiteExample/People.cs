using SQLite;
using System;

namespace XamarinFormsExamples.SQLiteExample
{
    public class People
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
