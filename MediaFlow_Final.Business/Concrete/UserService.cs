using MediaFlow_Final.Business.Abstract;
using MediaFlow_Final.DataAccess.Abstract;
using MediaFlow_Final.Entities.Models;

namespace MediaFlow_Final.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserDal _userDal;

        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _userDal.GetList();
        }

        public async Task AddAsync(User user)
        {
            await _userDal.Add(user);
        }

        public async Task UpdateAsync(User user)
        {
            await _userDal.Update(user);
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _userDal.Get(user => user.Id == id);
            await _userDal.Delete(user);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userDal.Get(user => user.Id == id);
        }
    }
}
