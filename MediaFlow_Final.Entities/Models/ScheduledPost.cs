namespace MediaFlow_Final.Entities.Models
{
    public class ScheduledPost
    {
        public int Id { get; set; }
        public DateTime ScheduledDate { get; set; }
        public bool IsPosted { get; set; }

        // Foreign Key for Social Media Account
        public int SocialMediaAccountId { get; set; }
        public SocialMediaAccount SocialMediaAccount { get; set; }

        // Foreign Key for Content Post
        public int ContentPostId { get; set; }
        public ContentPost ContentPost { get; set; }
    }
}
