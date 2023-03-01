
using ExpensesTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTracker.Data
{
    public class ExpensesTrackedDb : DbContext
    {
        public ExpensesTrackedDb(DbContextOptions<ExpensesTrackedDb> options) : base(options) { }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}


