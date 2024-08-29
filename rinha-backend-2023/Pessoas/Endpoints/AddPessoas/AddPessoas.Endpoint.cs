using Microsoft.AspNetCore.Mvc;
using rinha_backend_2023.Pessoas.Services;

namespace rinha_backend_2023.Pessoas.Endpoints.AddPessoas
{
    public static class AddPessoas
    {
        public static async Task<IResult> AddPessoasAsync([FromBody] RequestAddPessoa request, [FromServices] IAddPessoasService service)
        {
            var result = await service.ExecuteAsync(request);

            return result switch
            {
                null => Results.UnprocessableEntity(),
                _ => Results.Created(new Uri($"https://localhost:7102/pessoas/{result.id}"), result)
            };
        }
    }

    public record struct RequestAddPessoa(string? apelido, string? nome, DateOnly nascimento, List<string>? stack);
}
