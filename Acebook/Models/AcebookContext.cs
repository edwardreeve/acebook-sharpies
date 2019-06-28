using Microsoft.EntityFrameworkCore;
namespace Acebook.Models {
  public class AcebookContext : DbContext {
    public AcebookContext (DbContextOptions<AcebookContext> options) : base (options) { }
    public DbSet<Post> Post { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<Comment> Comment { get; set; }
  }
}