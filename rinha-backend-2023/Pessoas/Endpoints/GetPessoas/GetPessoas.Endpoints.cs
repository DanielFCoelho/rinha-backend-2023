using Microsoft.AspNetCore.Mvc;
using rinha_backend_2023.Pessoas.Services;

namespace rinha_backend_2023.Pessoas.Endpoints.GetPessoas;

public static class GetPessoas
{
    public static async Task<IResult> GetPessoaByIdAsync(Guid id,  [FromServices] IGetPessoasService service)
    {
        Domain.Pessoa? result = await service.GetPessoaById(id);

        return result switch
        {
            null => Results.NotFound(),
            _ => Results.Ok(result),
        };
    }

    public static async Task<IResult> GetPessoasByTermsAsync([FromQuery] string t, [FromServices] IGetPessoasService service)
    {
        throw new NotImplementedException();
    }

    public static async Task<IResult> GetTotalPessoasAsync([FromServices] IGetPessoasService service)
    {
        var x = await service.GetCountPessoas();
        return Results.Ok(x);
    }
}
