using rinha_backend_2023.Pessoas.Domain;

namespace rinha_backend_2023.Pessoas.Services
{
    public class GetPessoasService : IGetPessoasService
    {
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
    }
}
