using Microsoft.EntityFrameworkCore;
using Objectanalys.Models.Entities;

namespace Objectanalys.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<UserEntity> Users { get; set; }

}
