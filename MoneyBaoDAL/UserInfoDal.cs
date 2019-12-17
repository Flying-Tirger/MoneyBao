using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PubilcHelper;
namespace MoneyBaoDAL
{
    public class UserInfoDal
    {

        /// <summary>
        /// 添加的用户信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(UserInfoModel model)
        {

            string sql = $"insert into UserInfo values( newId(),'{model.UserEmail}','{model.UserPwd}','{model.UserSex}','{model.FirstEncryPetdId}','{model.FirstEncryPetdPwd}','{model.SecondEncryPetdId}','{model.SecondEncryPetdPwd}','{model.ThreedEncryPetdId}','{model.ThreedEncryPetdPwd}',getDate(),'1','{model.HeadFile}','0','0','0','{model.PhoneNumber}','{model.DealPwd}','{model.IdentityId}','{model.BankCard}')";
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 邮箱登录
        /// </summary>
        /// <param name="UserEmail">邮箱</param>
        /// <param name="UserPwd">密码</param>
        /// <returns></returns>
        public int UserInfoExSar(string UserEmail, string UserPwd)
        {
            string sql = $"select count(1) from UserInfo where UserEmail='{UserEmail}' and UserPwd='{UserPwd}'";
            return Convert.ToInt32(DBHelper.ExecuteScalar(sql));
        }
        /// <summary>
        /// 修改个人信息 性别 昵称 头像 密保
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdataUserName(UserInfoModel model)
        {
            string sql = "";
            if (string.IsNullOrWhiteSpace(model.FirstEncryPetdPwd))
            {
                sql = $"update UserInfo set FirstEncryPetdId='{model.FirstEncryPetdId}',ThreedEncryPetdPwd='{model.ThreedEncryPetdPwd}',FirstEncryPetdPwd='{model.FirstEncryPetdPwd}',SecondEncryPetdId='{model.SecondEncryPetdId}',SecondEncryPetdPwd='{model.SecondEncryPetdPwd}',ThreedEncryPetdId='{model.ThreedEncryPetdId}' where UserEmila='{model.UserEmail}' ";
            }
            else
            {
                sql = $"update UserInfo set UserName='{model.UserName}',UserSex='{model.UserSex}',HeadFile='{model.HeadFile}' where UserEmila='{model.UserEmail}'";
            }

            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改成长值、积分、钱包
        /// </summary>
        /// <param name="UserEmail">邮箱</param>
        /// <param name="m">变动量</param>
        /// <param name="distinguish">0是积分，1是成长值,2是钱包</param>
        /// <returns></returns> 
        public int UpdataIntergral(string UserEmail, decimal m, int distinguish)
        {
            string sql = "";
            if (distinguish == 0)
            {
                sql = $"update UserInfo set Intergral+='{m}' where UserEmail='{UserEmail}'";

            }
            if (distinguish == 1)
            {
                sql = $"update UserInfo set GrowthValue+='{m}' where UserEmail='{UserEmail}'";
            }
            if (distinguish == 2)
            {

                sql = $"update UserInfo set MoneyBag+='{m}' where UserEmail='{UserEmail}'";
            }
            return DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 验证用户是否存在以及修改登录密码.修改交易密码
        /// </summary>
        /// <param name="UserEmail">邮箱</param>
        /// <param name="distinguish">0是登录密码 1是交易密码 2是身份证 3是银行卡,4是验证账号</param>
        /// <param name="variable">变量值</param>
        /// <returns></returns>
        public int UserEmilaVerify(string UserEmail, int distinguish, string variable = "")
        {    
                string sql = "";
                if (distinguish == 4)
                {
                    string sqll = "select count(1) from UserInfo where UserEmail='" + UserEmail+"'";
                    return Convert.ToInt32(DBHelper.ExecuteScalar(sqll));
                }
                if (distinguish == 0)
                {
                    sql = $"update userinfo set userpwd='{variable}' where UserEmail='{UserEmail}'";
                }
                if (distinguish == 1)
                {
                    sql = $"update userinfo set DealPwd='{variable}' where UserEmail='{UserEmail}'";
                }
                if (distinguish == 2)
                {
                    sql = $"update userinfo set IdentityId='{variable}' where UserEmail='{UserEmail}'";
                }
                if (distinguish == 3)
                {
                    sql = $"update userinfo set BankCard='{variable}' where UserEmail='{UserEmail}'";
                }
                return DBHelper.ExecuteNonQuery(sql);
            

        }
        /// <summary>
        /// 显示用户信息
        /// </summary>
        /// <param name="UserEmail">用户邮箱</param>
        /// <returns></returns>
        public List<UserInfoModel> Get(string UserEmail)
        {
            return DBHelper.GetToList<UserInfoModel>($"select UserEmail,UserSex,FirstEncryPetdId,SecondEncryPetdId,ThreedEncryPetdId,CreateTime,HeadFile,UserName,Intergral,MoneyBag,PhoneNumber,IdentityId,BankCard from userinfo where UserEmail='{UserEmail}'");
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
            string sql = $"select count(1) from userinfo where FirstEncryPetdPwd='{FirstEncryPetdPwd}' and SecondEncryPetdPwd='{SecondEncryPetdPwd}' and ThreedEncryPetdPwd='{ThreedEncryPetdPwd}' and UserEmail='{UserEmail}' ";
            return Convert.ToInt32(DBHelper.ExecuteScalar(sql));
        }



    }
}