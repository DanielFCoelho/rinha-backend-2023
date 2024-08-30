using Microsoft.EntityFrameworkCore;
using rinha_backend_2023.Capabilities.Persistence;
using rinha_backend_2023.Pessoas.Domain;

namespace rinha_backend_2023.Pessoas.Services;

public class GetPessoasService(RinhaDBContext context) : IGetPessoasService
{
    public async Task<int> GetCountPessoas() => await context.Pessoas.CountAsync();

    public async Task<Pessoa?> GetPessoaById(Guid id) => await context.Pessoas.FindAsync(id);

    public async Task<List<Pessoa>> GetPessoasByTerms(string terms)
    {
        return context.Pessoas.AsEnumerable().Where(k => k.apelido.Contains(terms) ||
            k.nome.Contains(terms) || (k.stack != null ? k.stack.Any(d => d.Contains(terms)) : false))
            .ToList();
    }
}

public interface IGetPessoasService
{
    Task<List<Domain.Pessoa>> GetPessoasByTerms(string terms);
    Task<Domain.Pessoa?> GetPessoaById(Guid id);
    Task<int> GetCountPessoas();
}
