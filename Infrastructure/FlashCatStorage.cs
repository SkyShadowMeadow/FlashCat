using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure
{
    public class FlashCatStorage : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Set> Sets { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Card> Cards { get; set; }

        public FlashCatStorage(DbContextOptions<FlashCatStorage> options) : base(options)
        { }

        public FlashCatStorage()
        {
        }
    }

    public class FlashCatStorageContextFactory : IDesignTimeDbContextFactory<FlashCatStorage>
{
    public FlashCatStorage CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<FlashCatStorage>();
        optionsBuilder.UseSqlServer("your connection string");

        return new FlashCatStorage(optionsBuilder.Options);
    }
}
}