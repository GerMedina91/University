using Microsoft.EntityFrameworkCore;
using UniversityApi.Models.DataModels;

namespace UniversityApi.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        {
            
        }


        //TODO: Add DbSets
        public DbSet<User> user { get; set; }
        public DbSet<Course> course { get; set; }

    }
}
