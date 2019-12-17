using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoDAL;
namespace MoneyBaoBll
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class UserInfoBll
    {
        UserInfoDal dal = new UserInfoDal();
        /// <summary>
        /// 添加的用户信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(UserInfoModel model)
        {
            return dal.Post(model);
        }
        /// <summary>
        /// 邮箱登录
        /// </summary>
        /// <param name="UserEmail">邮箱</param>
        /// <param name="UserPwd">密码</param>
        /// <returns></returns>
        public int UserInfoExSar(string UserEmail, string UserPwd)
        {
            return dal.UserInfoExSar(UserEmail, UserPwd);
        }
        /// <summary>
        /// 修改个人信息 性别 昵称 头像 密保
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdataUserName(UserInfoModel model)
        {
            return UpdataUserName(model);
        }
        
        /// <summary>
        /// 验证用户是否存在以及修改登录密码.修改交易密码
        /// </summary>
        /// <param name="UserEmail">邮箱</param>
        /// <param name="distinguish">0是登录密码 1是交易密码 2是身份证 3是银行卡</param>
        /// <param name="variable">变量值</param>
        /// <returns></returns>
        public int UserEmilaVerify(string UserEmail, int distinguish, string variable = "")
        {
            return dal.UserEmilaVerify(UserEmail, distinguish, variable);
        }
        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="UserEmail">用户邮箱</param>
        /// <returns></returns>
        public List<UserInfoModel> Get(string UserEmail)
        {
            return  dal.Get(UserEmail);
        }
        /// <summary>
        /// 验证密保
        /// </summary>
        /// <param name="FirstEncryPetdPwd">答案一</param>
        /// <param name="SecondEncryPetdPwd">答案二</param>
        /// <param name="ThreedEncryPetdPwd">答案三</param>
        /// <param name="UserEmail"></param>
        /// <returns></returns>
        public int EncryPetdVerify(string FirstEncryPetdPwd, string SecondEncryPetdPwd, string ThreedEncryPetdPwd, string UserEmail)
        {
            return dal.EncryPetdVerify(FirstEncryPetdPwd, SecondEncryPetdPwd, ThreedEncryPetdPwd, UserEmail);
        }

    }
}
