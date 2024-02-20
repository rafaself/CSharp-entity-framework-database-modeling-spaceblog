
namespace SpaceBlogDb.Models;

public class PostsCategoryPost
{
    public int PostId { get; set; }
    public Post? Post { get; set; }
    public int PostsCategoryId { get; set; }
    public PostsCategory? PostsCategory { get; set; }
}
