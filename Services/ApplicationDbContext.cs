using Microsoft.EntityFrameworkCore;

namespace E_G_FinalProject.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

    }
}
