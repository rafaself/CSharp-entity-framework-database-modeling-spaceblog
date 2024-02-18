using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Models.DTOs;

public class UserDto : IBaseModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<Post>? Posts { get; set; }
}

