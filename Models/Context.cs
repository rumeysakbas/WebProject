using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

namespace WebProject.Models
{
    public class Context:DbContext
    {
        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RumisBC;Trusted_Connection=True;");
        }


    }
}
