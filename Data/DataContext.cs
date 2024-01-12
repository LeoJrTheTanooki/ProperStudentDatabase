using StudentDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<Student> Students { get; set; }
}