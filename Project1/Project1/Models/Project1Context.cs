using Microsoft.EntityFrameworkCore;

namespace Project1.Models
{
    public class Project1Context:DbContext
    {
        public Project1Context()
        {

        }
        public Project1Context(DbContextOptions<Project1Context> options):base(options)
        {

        }
        public virtual DbSet<Register> Registers { get; set; }
    }
}
