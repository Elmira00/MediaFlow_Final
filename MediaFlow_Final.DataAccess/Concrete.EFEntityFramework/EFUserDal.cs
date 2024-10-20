using MediaFlow_Final.Core.DataAccess.EntityFramework;
using MediaFlow_Final.DataAccess.Abstract;
using MediaFlow_Final.Entities.Models;

namespace MediaFlow_Final.DataAccess.Concrete.EFEntityFramework
{
    public class EFUserDal : EFEntityFrameworkRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public EFUserDal(NorthwindContext context) : base(context)
        {
        }
    }
}
