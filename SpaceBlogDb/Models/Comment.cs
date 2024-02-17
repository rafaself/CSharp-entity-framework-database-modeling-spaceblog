using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Models;

public class Comment : IBaseModel
{
    public int Id { get; }
    public string Text { get; set; } = string.Empty;
    public int UserId { get; set; }
    public User? User { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
}
