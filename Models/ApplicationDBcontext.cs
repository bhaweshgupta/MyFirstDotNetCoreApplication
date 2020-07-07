using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstDotNetCoreApplication.Models
{
    public class ApplicationDBcontext:DbContext
    {

        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options):base(options)
        {

        }
        public DbSet<Book> Book { get; set; }
    }
}
