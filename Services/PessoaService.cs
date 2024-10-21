using CadastroPessoas.Server.Models;
using Microsoft.EntityFrameworkCore;

public class PessoaService
{
    private readonly AppDbContext _context;

    public PessoaService(AppDbContext context)
    {
        _context = context;
    }

    public async Task AddPessoa(Pessoa pessoa)
    {
        _context.Pessoas.Add(pessoa);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Pessoa>> GetPessoas()
    {
        return await _context.Pessoas.ToListAsync();
    }
}
