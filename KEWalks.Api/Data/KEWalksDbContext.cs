using Microsoft.EntityFrameworkCore;

namespace KEWalks.Api.Data
{
    public class KEWalksDbContext : DbContext
    {
        public KEWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
    }
}
