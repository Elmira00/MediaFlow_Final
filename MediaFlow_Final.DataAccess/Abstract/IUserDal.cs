using MediaFlow_Final.Core.DataAccess;
using MediaFlow_Final.Entities.Models;

namespace MediaFlow_Final.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        // You can add any specific methods related to the User entity here.
    }
}
