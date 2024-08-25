namespace rinha_backend_2023.Pessoas.Domain;

public class Pessoa : DomainBase
{
    public string Apelido { get; set; }
    public string Nome { get; set; }
    public DateOnly Nascimento { get; set; }
    public string[]? Stack { get; set; }
}
