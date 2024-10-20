namespace MediaFlow_Final.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }

        public ICollection<SocialMediaAccount> SocialMediaAccounts { get; set; }
    }
}
