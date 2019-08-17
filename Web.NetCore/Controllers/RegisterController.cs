using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.NetCore.Model.Models;

namespace Web.NetCore.Controllers
{
    /// <summary>
    /// 注册
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult<UserInfo> Register(UserInfo userInfo)
        {
            return Ok(new
            {
                sucess = true,
                message = "欢迎你！，"
            });
            
        }
    }
}