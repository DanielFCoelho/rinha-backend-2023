using Microsoft.EntityFrameworkCore;
using rinha_backend_2023.Capabilities.Persistence;
using rinha_backend_2023.Pessoas.Domain;
using rinha_backend_2023.Pessoas.Endpoints.AddPessoas;

namespace rinha_backend_2023.Pessoas.Services;

public class AddPessoasService(RinhaDBContext rinhaDBContext) : IAddPessoasService
{
    public async Task<Pessoa?> ExecuteAsync(RequestAddPessoa obj)
    {
        Pessoa? pessoa = Map(obj);
        if (pessoa is null) return null;

        try
        {
            await rinhaDBContext.AddAsync(pessoa);
            await rinhaDBContext.SaveChangesAsync();
        }
        catch (DbUpdateException ex)
        {
            if (((Npgsql.PostgresException)ex.InnerException).ConstraintName == "pessoas_unique") return null;

            throw ex;
        }

        return pessoa;
    }

    private Pessoa? Map(RequestAddPessoa obj)
    {
        return obj switch
        {
            { apelido: null } => null,
            { nome: null } => null,
            _ => new Pessoa(Guid.NewGuid(), obj.apelido!, obj.nome!, obj.nascimento, obj.stack)
        };
    }
}

public interface IAddPessoasService
{
    Task<Pessoa?> ExecuteAsync(RequestAddPessoa obj);
}
