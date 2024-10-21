using Microsoft.EntityFrameworkCore;
using CadastroPessoas.Server.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Pessoa> Pessoas { get; set; }
}
