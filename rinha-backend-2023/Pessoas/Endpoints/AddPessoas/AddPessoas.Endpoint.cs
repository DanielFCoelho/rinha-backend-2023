using Microsoft.AspNetCore.Mvc;
using rinha_backend_2023.Pessoas.Add.Services;

namespace rinha_backend_2023.Pessoas.Endpoints.AddPessoas
{
    public static class AddPessoas
    {
        public static async Task<IResult> AddPessoasAsync([FromBody] RequestAddPessoa request, [FromServices] IAddPessoasService service )
        {
            return null;
        }
    }

    public class RequestAddPessoa 
    {
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateOnly Nascimento { get; set; }
        public string[]? Stack { get; set; }
    }
}
