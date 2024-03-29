﻿using SpaceBlogDb.Models.Interfaces;

namespace SpaceBlogDb.Models;

public class Post : IBaseModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int UserId { get; set; }
    public User? User { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<PostsCategoryPost>? PostsCategoriesPosts { get; set; }
}
