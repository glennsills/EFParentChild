using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Child>()
            //    .HasOne(p => p.Parent)
            //    .WithMany(b => b.Children)
            //    .HasForeignKey(p => p.ParentId)
            //    .HasConstraintName("FK_Child_Parent");
        }
    }
}
