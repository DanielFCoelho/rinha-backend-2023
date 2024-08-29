using Microsoft.EntityFrameworkCore;
using rinha_backend_2023.Capabilities.Persistence;
using rinha_backend_2023.Pessoas.Domain;

namespace rinha_backend_2023.Pessoas.Services;

public class GetPessoasService(RinhaDBContext context) : IGetPessoasService
{
    public async Task<int> GetCountPessoas() => await context.Pessoas.CountAsync();

    public async Task<Pessoa?> GetPessoaById(Guid id) => await context.Pessoas.FindAsync(id);

    public Task<IEnumerable<Pessoa>> GetPessoasByTerms(string terms)
    {
        throw new NotImplementedException();
    }
}

public interface IGetPessoasService
{
    Task<IEnumerable<Domain.Pessoa>> GetPessoasByTerms(string terms);
    Task<Domain.Pessoa?> GetPessoaById(Guid id);
    Task<int> GetCountPessoas();
}
