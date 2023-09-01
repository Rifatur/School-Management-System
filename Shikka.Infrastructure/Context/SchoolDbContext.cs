using Microsoft.EntityFrameworkCore;

namespace Shikka.Infrastructure.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }

    }
}
