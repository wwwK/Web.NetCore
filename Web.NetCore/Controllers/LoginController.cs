using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.NetCore.Helper;
using Web.NetCore.IService;
using Web.NetCore.Service;

namespace Web.NetCore.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    public class LoginController : Controller
    {
        readonly IUserInfoServices _userInfoServices;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userInfoServices"></param>
        public LoginController(IUserInfoServices userInfoServices)
        {
            _userInfoServices = userInfoServices;
        }


        /// <summary>
        /// 登录认证，获取Token
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pass">密码</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<object> GetJwtStr(string name, string pass)
        {
            
            var userinfo = await _userInfoServices.Query(u => u.USER_LOGIN_NAME == name && u.USER_PASSWORD == pass);
            if (userinfo.Count == 1)
            {
                string jwtStr = string.Empty;
                bool suc = false;

                // 获取用户的角色名，请暂时忽略其内部是如何获取的，可以直接用 var userRole="Admin"; 来代替更好理解。
                var userRole = "Admin";//await _sysUserInfoServices.GetUserRoleNameStr(name, pass);
                if (userRole != null)
                {
                    // 将用户id和角色名，作为单独的自定义变量封装进 token 字符串中。
                    TokenModelJwt tokenModel = new TokenModelJwt { Uid = 1, Role = userRole };
                    jwtStr = JwtHelper.IssueJwt(tokenModel);//登录，获取到一定规则的 Token 令牌
                    suc = true;
                }
                else
                {
                    jwtStr = "login fail!!!";
                }

                return Ok(new
                {
                    success = suc,
                    token = jwtStr
                });
            }
            else
            {
                return BadRequest(new
                {
                    success = false,
                    errorcode = 400,
                    message = "当前用户不存在，请先注册用户！"
                });
            }

        }

    }
}