using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SlunchevIzgrev.Data
{
    public class SlunchevIzgrevDbContext : IdentityDbContext<User>
    {
        public SlunchevIzgrevDbContext(DbContextOptions<SlunchevIzgrevDbContext> options)
            : base(options)
        {
        }
    }
}