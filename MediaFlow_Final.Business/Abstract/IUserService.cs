using MediaFlow_Final.Entities.Models;

namespace MediaFlow_Final.Business.Abstract
{
    public interface IUserService
    {
        Task<List<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int id);
        Task<User> GetByIdAsync(int id);
    }
}
