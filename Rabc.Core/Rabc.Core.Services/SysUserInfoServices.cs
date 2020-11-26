using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Rabc.Core.IServices;
using Rabc.Core.Model;
using Rabc.Core.Repository;

namespace Rabc.Core.Services
{
    public class SysUserInfoServices : BaseServices<sys_user_info>, ISysUserInfoServices
    {
        private readonly ISysUserInfoRepository _sysUserInfoRepository;

        public SysUserInfoServices(ISysUserInfoRepository sysUserInfoRepository)
        {
            this._sysUserInfoRepository = sysUserInfoRepository;
        }
        public async Task<sys_user_info> Get()
        {
            return await _sysUserInfoRepository.Get();
        }
    }
}
