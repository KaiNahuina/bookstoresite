using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Libro_Book_Store.Data
{
    public class AppDbContext : DbContext/*IdentityDbContext<ApplicationUser>*/
    {
        public AppDbContext(DbContextOptions/*<AppDbContext>*/ options) : base(options)
        {

        }

        public DbSet<Libros> LibrosList { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}

    }

    
}
