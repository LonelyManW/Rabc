using Rabc.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Rabc.Core.Repository
{
    public interface ISysUserInfoRepository : IBaseRepository<sys_user_info>
    {
        Task<sys_user_info> Get();
    }
}
