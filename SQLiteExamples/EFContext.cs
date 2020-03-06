using Microsoft.EntityFrameworkCore;
using XamarinFormsExamples.SQLiteExample;

namespace SQLiteExamples
{
    public class EFContext : DbContext
    {
        public DbSet<People> Peoples { get; set; }
        private string _databasePath;
        public EFContext(string databasePath)
        {
            _databasePath = databasePath;
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
