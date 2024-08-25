using Microsoft.AspNetCore.Mvc;
using rinha_backend_2023.Pessoas.Services;

namespace rinha_backend_2023.Pessoas.Endpoints.GetPessoas;

public static class GetPessoas
{
    public static async Task<IResult> GetPessoaByIdAsync(Guid id,  [FromServices] IGetPessoasService service)
    {
        return null;
    }
}
