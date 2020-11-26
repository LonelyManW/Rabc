using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Rabc.Core.IServices;
using Rabc.Core.Model;

namespace Rabc.Core.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ISysUserInfoServices _sysUserInfoServices;

        public UserController(ISysUserInfoServices sysUserInfoServices)
        {
            this._sysUserInfoServices = sysUserInfoServices;
        }

        /// <summary>
        /// 测试
        /// </summary>
        /// <returns></returns>
        [HttpGet("get")]
        public async Task<sys_user_info> Get()
        {
            return await _sysUserInfoServices.Get();
        }
    }
}
