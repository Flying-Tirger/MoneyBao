using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MoneyBaoBll;
using MoneyBaoModel;

namespace MoneyBaoAPI.Controllers
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfoController : ApiController
    {
        UserInfoBll bll = new UserInfoBll();

        /// <summary>
        /// 添加的用户信息
        /// </summary>
        /// <param name="model">用户信息</param>
        /// <returns></returns>
        public int Post(UserInfoModel model)
        {
            return bll.Post(model);
        }
        /// <summary>
        /// 邮箱登录
        /// </summary>
        /// <param name="UserEmail">邮箱</param>
        /// <param name="UserPwd">密码</param>
        /// <returns></returns>
        public int GetLogin(string UserEmail, string UserPwd)
        {
            return bll.UserInfoExSar(UserEmail, UserPwd);
        }
        /// <summary>
        /// 修改个人信息 性别 昵称 头像 密保
        /// </summary>
        /// <param name="model">个人信息 性别 昵称 头像 密保</param>
        /// <returns></returns>
        public int PutUserName(UserInfoModel model)
        {
            return bll.UpdataUserName(model);
        }

        /// <summary>
        /// 验证用户是否存在以及修改登录密码.修改交易密码
        /// </summary>
        /// <param name="UserEmail">邮箱</param>
        /// <param name="distinguish">0是登录密码 1是交易密码 2是身份证 3是银行卡,4是验证账号</param>
        /// <param name="variable">变量值</param>
        /// <returns></returns>
        public int GetEmilaVerify(string UserEmail, int distinguish, string variable = "")
        {
            return bll.UserEmilaVerify(UserEmail, distinguish, variable);
        }
        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="UserEmail">用户邮箱</param>
        /// <returns></returns>
        public List<UserInfoModel> Get(string UserEmail)
        {
            return bll.Get(UserEmail);
        }
        /// <summary>
        /// 验证密保
        /// </summary>
        /// <param name="FirstEncryPetdPwd">答案一</param>
        /// <param name="SecondEncryPetdPwd">答案二</param>
        /// <param name="ThreedEncryPetdPwd">答案三</param>
        /// <param name="UserEmail"></param>
        /// <returns></returns>
        public int GetEncryPetdVerify(string FirstEncryPetdPwd, string SecondEncryPetdPwd, string ThreedEncryPetdPwd, string UserEmail)
        {
            return bll.EncryPetdVerify(FirstEncryPetdPwd, SecondEncryPetdPwd, ThreedEncryPetdPwd, UserEmail);
        }
    }
}
