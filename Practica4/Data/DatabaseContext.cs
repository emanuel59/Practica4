using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practica4.Models;

namespace Practica4.Data
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
                : base(options)
            {}
        public DbSet<Practica4.Models.Fail> Fail{ get; set; }

        }
}