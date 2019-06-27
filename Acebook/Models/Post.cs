using System;

namespace Acebook.Models {
  public class Post {

    public long Id { get; set; }
    public long UserId { get; set; }
    public string Body { get; set; }
    public DateTime CreatedAt { get; set; }

    public Post CreatePost(string body, long userId) {
      this.UserId = userId;
      this.Body = body;
      this.CreatedAt = DateTime.Now;

      return this;
    }
  }
}
