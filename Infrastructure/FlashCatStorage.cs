using System;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class FlashCatStorage : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:cath.database.windows.net,1433;Initial Catalog=FlashCat;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }
    }
}