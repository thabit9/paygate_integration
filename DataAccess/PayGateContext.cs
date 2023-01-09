using PayGate_integration.Models;
using PayGate_integration.PayGate;
using Microsoft.EntityFrameworkCore;

namespace PayGate_integration.DataAccess
{
    public class PayGateContext : DbContext
    {
        public PayGateContext()
        {            
        }
        public PayGateContext(DbContextOptions<PayGateContext> options) 
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