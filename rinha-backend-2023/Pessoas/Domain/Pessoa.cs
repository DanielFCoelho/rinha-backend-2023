using System.ComponentModel.DataAnnotations.Schema;

namespace rinha_backend_2023.Pessoas.Domain;

[Table("pessoas")]
public class Pessoa : DomainBase
{
    public Pessoa(Guid id, string apelido, string nome, DateOnly nascimento, List<string>? stack) : base(id)
    {
        this.apelido = apelido;
        this.nome = nome;
        this.nascimento = nascimento;
        this.stack = stack;
    }
    public string apelido { get; private set; }
    public string nome { get; private set; }
    public DateOnly nascimento { get; private set; }
    public List<string>? stack { get; private set; }
}
