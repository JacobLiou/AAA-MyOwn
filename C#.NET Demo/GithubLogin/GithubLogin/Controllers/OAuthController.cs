using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MrHuo.OAuth.Github;

namespace GithubLogin.Controllers
{
    public class OAuthController : Controller
    {
        #region GitHub授权+回调

        //发起第三方授权申请
        [HttpGet("oauth/github")]
        public IActionResult Github([FromServices] GithubOAuth githubOAuth)
        {
            return Redirect(githubOAuth.GetAuthorizeUrl());
        }

        //第三方授权成功后回调方法
        [HttpGet("oauth/githubcallback")]
        public async Task<IActionResult> GithubCallback(
            [FromServices] GithubOAuth githubOAuth,
            [FromQuery] string code)
        {
            return Json(await githubOAuth.AuthorizeCallback(code));
        }
        #endregion
    }
}
