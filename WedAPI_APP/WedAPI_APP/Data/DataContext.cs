using Microsoft.EntityFrameworkCore;

namespace WedAPI_APP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Merchandise> Merchandises { get; set; }
    }
}
