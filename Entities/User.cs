using ApiCm.Commons;

namespace ApiCm.Entities;

public class User : BaseEntity
{
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required bool IsActive { get; set; }
    public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
}
