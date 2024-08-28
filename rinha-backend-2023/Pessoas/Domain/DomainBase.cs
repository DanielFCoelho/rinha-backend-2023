using System.ComponentModel.DataAnnotations;

namespace rinha_backend_2023.Pessoas.Domain;

public abstract class DomainBase
{
    [Key]
    public Guid Id { get; set; }
}
