using Microsoft.EntityFrameworkCore;
using SpaceBlogDb.Models;

namespace SpaceBlogDb.Repositories;

public class PostRepository(CustomDbContext dbContext) : BaseRepository<Post>(dbContext)
{

}