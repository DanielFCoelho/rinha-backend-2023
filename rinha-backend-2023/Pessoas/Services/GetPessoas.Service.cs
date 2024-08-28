using Microsoft.EntityFrameworkCore;
using rinha_backend_2023.Capabilities.Persistence;
using rinha_backend_2023.Pessoas.Domain;

namespace rinha_backend_2023.Pessoas.Services
{
    public class GetPessoasService(RinhaDBContext context) : IGetPessoasService
    {
        public async Task<int> GetCountPessoas() => await context.Pessoas.CountAsync();

        public Task<Pessoa> GetPessoaById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pessoa>> GetPessoasByTerms()
        {
            throw new NotImplementedException();
        }
    }

    public interface IGetPessoasService
    {
        Task<IEnumerable<Domain.Pessoa>> GetPessoasByTerms();
        Task<Domain.Pessoa> GetPessoaById(Guid id);
        Task<int> GetCountPessoas();
    }
}
