using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Models;

public class PostsCategory : IBaseModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public ICollection<PostsCategoryPost>? PostsCategoriesPosts { get; set; }
}
