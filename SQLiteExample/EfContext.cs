using Microsoft.EntityFrameworkCore;
using System;
using XamarinFormsExamples.SQLiteExample;

namespace SQLiteExample
{
    public class EfContext : DbContext
    {
        public DbSet<People> Peoples{ get; set; }
        private string _database;
        public EfContext(string dbPath)
        {
            _database = dbPath;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_database}");
        }
    }
}
