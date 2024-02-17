using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Models;

public class User : IBaseModel
{
    public int Id { get; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<Post>? Posts { get; set; }
}
