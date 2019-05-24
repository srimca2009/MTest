using Microsoft.EntityFrameworkCore;

namespace MTest.Model
{
    public class MTContext : DbContext
    {
        public MTContext(DbContextOptions<MTContext> options) : base(options)
        {

        }

        //Entities
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
