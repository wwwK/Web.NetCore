using Web.NetCore.IRepository;
using Web.NetCore.IService;
using Web.NetCore.Model.Models;
using Web.NetCore.Service.Base;

namespace Web.NetCore.Service
{
    public class UserInfoServices : BaseServices<UserInfo>,IUserInfoServices
    {
        IUserInfoRepository dal;

        public UserInfoServices(IUserInfoRepository dal)
        {
            this.dal = dal;
            base.baseDal = dal;
        }

    }
}
