using BManager.Utils.Abstractions;

namespace BManager.Application.Entites;

public class Role : AuditEntity
{
    public string Name { get; set; }
}