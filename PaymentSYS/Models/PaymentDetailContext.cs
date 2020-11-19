using Microsoft.EntityFrameworkCore;

namespace PaymentSYS.Models
{
    public class PaymentDetailContext : DbContext 
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        { 
        
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; } //after migration PaymentDetails table will be created in SQL Server Database.
    }
}
