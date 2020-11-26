using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Rabc.Core.AuthHelper
{
    /// <summary>
    /// 认证处理器的实现
    /// </summary>
    public class ApiResponseHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public ApiResponseHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 重写 抽象方法HandleChallengeAsync()处理质询过程
        /// （和认证方法类似，质询也是优先判断是否要转发给其他模式质询，如果没有的话，再调用自身的抽象方法HandleChallengeAsync处理质询过程）
        /// 默认返回401
        /// </summary>
        /// <param name="properties"></param>
        /// <returns>401</returns>
        protected override async Task HandleChallengeAsync(AuthenticationProperties properties)
        {
            Response.ContentType = "application/json";
            Response.StatusCode = 401;
            await Response.WriteAsync(JsonConvert.SerializeObject(""));
        }

        /// <summary>
        /// 重写 抽象方法HandleForbiddenAsync()自身处理禁止过程：
        /// 禁止方法，同样还是优先判断是否要转发给其他模式禁止。如果不需要，则由HandleForbiddenAsync()方法自身处理禁止过程：
        /// 默认返回403
        /// </summary>
        /// <param name="properties"></param>
        /// <returns>403</returns>
        protected override async Task HandleForbiddenAsync(AuthenticationProperties properties)
        {
            Response.ContentType = "application/json";
            Response.StatusCode = 403;
            await Response.WriteAsync(JsonConvert.SerializeObject(""));
        }
    }
}
