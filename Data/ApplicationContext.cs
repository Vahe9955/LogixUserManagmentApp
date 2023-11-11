using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LogixUserManagmentApp.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> applicationUsers { get; set; }
    }
}