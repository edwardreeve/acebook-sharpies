using System;

namespace Acebook.Models {
  public class Post {

    public long Id { get; set; }
    public string Body { get; set; }
    public DateTime CreatedAt { get; set; }
  }
}
