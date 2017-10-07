using Microsoft.EntityFrameworkCore;

namespace EFParentChild
{
    class DbParentChild : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Child> Children { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ParentChildDb;Trusted_Connection=True;");
        }

    }
}
