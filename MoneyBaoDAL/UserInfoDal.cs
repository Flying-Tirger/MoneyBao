using MoneyBaoModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoDAL
{
    public class UserInfoDal
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MoneyLeopard;Integrated Security=True");
        #region 注册个人资料添加1
        /// <summary>
        /// 添加的用户信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UserInfoAdd(UserInfoModel model)
        {

            string sql = $"insert into UserInfo values( newId(),'{model.UserEmail}','{model.UserPwd}','{model.UserSex}','{model.FirstEncryPetdId}','{model.FirstEncryPetdPwd}','{model.SecondEncryPetdId}','{model.SecondEncryPetdPwd}','{model.ThreedEncryPetdId}','{model.ThreedEncryPetdPwd}',getDate(),'1','{model.HeadFile}','0','0','0','{model.PhoneNumber}','{model.DealPwd}','{model.IdentityId}','{model.BankCard}')";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }
        #endregion
        #region 2.登录
        /// <summary>
        /// 邮箱登录
        /// </summary>
        /// <param name="model">文本的值</param>
        /// <returns></returns>
        public int UserInfoExSar(UserInfoModel model)
        {
            string sql = $"select * from UserInfo where UserEmail='{model.UserEmail}' and UserPwd='{model.UserPwd}'";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            int n = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return n;
        }

        #endregion
        #region 4.修改头像
        /// <summary>
        /// 修改头像
        /// </summary>
        /// <param name="model">数据</param>
        /// <returns></returns>
        public int UpdataHeadFile(UserInfoModel model)
        {
            string sql = $"update from UserInfo HeadFile='{model.HeadFile}' where UserId='{model.UserId}'";
            return Examce(sql);
        }
        /// <summary>
        /// 修改昵称
        /// </summary>
        /// <param name="model">数据</param>
        /// <returns></returns>
        public int UpdataUserName(UserInfoModel model)
        {
            string sql = $"update from UserInfo UserName='{model.UserName}' where UserId='{model.UserId}'";
            conn.Open();
            return Examce(sql);
        }


        #endregion
        #region 5.修改获得积分
        public int UpdataIntergral(UserInfoModel model, int m)
        {
            string sql = $"update from UserInfo Intergral+='{m}' where UserId='{model.UserId}'";
            return Examce(sql);
        }
        #endregion
        #region 怎删改方法
        public int Examce(string sql)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            int n = cmd.ExecuteNonQuery();
            conn.Close();
            return n;
        }
        #endregion
    }
}