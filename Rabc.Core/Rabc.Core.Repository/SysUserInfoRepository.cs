using Rabc.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rabc.Core.Repository
{
    public class SysUserInfoRepository : BaseRepository<sys_user_info>, ISysUserInfoRepository

    {
        public async Task<sys_user_info> Get()
        {
            sys_user_info model = new sys_user_info()
            {
                login_name = "lastway",
                login_pwd = "123"
            };
            return model;
        }
    }
}
