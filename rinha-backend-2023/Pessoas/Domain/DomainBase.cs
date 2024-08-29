using System.ComponentModel.DataAnnotations;

namespace rinha_backend_2023.Pessoas.Domain;

public abstract class DomainBase
{
    protected DomainBase(Guid id)
    {
        this.id = id;
    }

    [Key]
    public Guid id { get; protected set; }
}
