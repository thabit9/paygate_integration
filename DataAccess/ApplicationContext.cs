using PayGate_integration.Models;
using PayGate_integration.PayGate;
using Microsoft.EntityFrameworkCore;

namespace PayGate_integration.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {            
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options)
        {
        } 
        public virtual DbSet<Transaction> Transactions { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            //code here...             
        }
    }
}