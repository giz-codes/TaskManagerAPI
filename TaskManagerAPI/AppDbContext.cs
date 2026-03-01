using Microsoft.EntityFrameworkCore;
using TaskManagerAPI.Models; 

namespace TaskManagerAPI;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<TodoTask> Tasks { get; set; }
}