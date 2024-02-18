using SpaceBlogDb.Models.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SpaceBlogDb.Models;

public class Comment : IBaseModel
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int UserId { get; set; }
    public User? User { get; set; }
    public int PostId { get; set; }
    public Post? Post { get; set; }
}
