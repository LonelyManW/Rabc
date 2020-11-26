using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rabc.Core.Model;

namespace Rabc.Core.IServices
{
    public interface ISysUserInfoServices : IBaseServices<sys_user_info>
    {
        Task<sys_user_info> Get();
    }
}
