using Microsoft.EntityFrameworkCore;
using CadastroPessoas.Server.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Pessoa> Pessoas { get; set; } = null!; 
}

