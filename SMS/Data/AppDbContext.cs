using Microsoft.EntityFrameworkCore;
using SMS.Data.Entities;

namespace SMS.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Lecturer> Lecturers { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
}
