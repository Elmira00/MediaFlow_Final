namespace MediaFlow_Final.Entities.Models
{
    public class ContentPost
    {
        public int Id { get; set; }
        public string Content { get; set; }  // The actual text, image, or video URL
        public DateTime CreatedAt { get; set; }

        // Navigation property (optional)
        public ICollection<ScheduledPost> ScheduledPosts { get; set; }
    }
}
