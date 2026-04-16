namespace Pustok.Models.Common;

public class BaseEntity
{
    public Guid Id { get; init; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
    }
}

// public class AuditableEntity: BaseEntity
// {
//     public DateTime CreatedAt{get;set;}
//     
//     public DateTime UpdatedAt{get;set;}
// }