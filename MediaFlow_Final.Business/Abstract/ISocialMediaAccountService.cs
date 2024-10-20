using MediaFlow_Final.Entities.Models;

namespace MediaFlow_Final.Business.Abstract
{
    public interface ISocialMediaAccountService
    {
        Task<IEnumerable<SocialMediaAccount>> GetAllAccountsAsync();
        Task<SocialMediaAccount> GetAccountByIdAsync(int id);
        Task CreateAccountAsync(SocialMediaAccount account);
        Task UpdateAccountAsync(SocialMediaAccount account);
        Task DeleteAccountAsync(int id);
    }
}
