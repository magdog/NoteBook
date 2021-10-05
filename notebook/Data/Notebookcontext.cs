using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using notebook.Models;
using Microsoft.EntityFrameworkCore;
namespace notebook.Data
{
    public class Notebookcontext : DbContext
    {
        public Notebookcontext(DbContextOptions<Notebookcontext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Person>().ToTable("Person");
        }
    }
}
