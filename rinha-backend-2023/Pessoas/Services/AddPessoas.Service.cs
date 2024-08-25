using rinha_backend_2023.Pessoas.Endpoints.AddPessoas;

namespace rinha_backend_2023.Pessoas.Add.Services
{
    public class AddPessoasService : IAddPessoasService
    {

        public async Task<bool> ExecuteAsync(RequestAddPessoa obj)
        {
            throw new NotImplementedException();
        }
    }

    public interface IAddPessoasService
    {
        Task<bool> ExecuteAsync(RequestAddPessoa obj);
    }
}
