using System;
namespace Acebook.Models
{
    public class Comment
    {
        public long Id { get; set; }
        public long userId { get; set; }
        public long postId { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}