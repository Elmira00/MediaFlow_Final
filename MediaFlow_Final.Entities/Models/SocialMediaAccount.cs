namespace MediaFlow_Final.Entities.Models
{
    public class SocialMediaAccount
    {
        public int Id { get; set; }
        public string Platform { get; set; } // e.g., Facebook, Twitter, Instagram
        public string Username { get; set; }
        public string AccessToken { get; set; }
        public DateTime LinkedAt { get; set; }

        // Foreign Key and Navigation Property
        public int UserId { get; set; }
        public User User { get; set; }

        // Navigation property for scheduled posts
        public ICollection<ScheduledPost> ScheduledPosts { get; set; }
    }
}
