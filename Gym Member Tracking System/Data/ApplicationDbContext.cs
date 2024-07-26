using Gym_Member_Tracking_System.Models;
using Microsoft.EntityFrameworkCore;


namespace Gym_Member_Tracking_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Members> Member { get; set; }
    }
}
