using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    public class UserInfoModel
    {
        /// <summary>
        /// 用户Id
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 邮箱账号
        /// </summary>
        public string UserEmail { get; set; }
        /// <summary>
        /// 用户密码(6-16)
        /// </summary>
        public string UserPwd { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool UserSex { get; set; }
        /// <summary>
        /// 密保问题1(连接密保表)
        /// </summary>
        public int FirstEncryPetdId { get; set; }
        /// <summary>
        /// 密保答案1
        /// </summary>
        public string FirstEncryPetdPwd { get; set; }
        /// <summary>
        /// 密保问题2(连接密保表)
        /// </summary>
        public int SecondEncryPetdId { get; set; }
        /// <summary>
        /// 密保答案2
        /// </summary>
        public string SecondEncryPetdPwd { get; set; }
        /// <summary>
        /// 密保问题3(连接密保表)
        /// </summary>
        public int ThreedEncryPetdId { get; set; }
        /// <summary>
        /// 密保答案3
        /// </summary>

        public string ThreedEncryPetdPwd { get; set; }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int UserState { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public string HeadFile { get; set; }
        /// <summary>
        /// 昵称(默认是邮箱账号)
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int Intergral { get; set; }
        /// <summary>
        /// 成长值
        /// </summary>
        public int GrowthValue { get; set; }
        /// <summary>
        /// 钱包
        /// </summary>
        public decimal MoneyBag { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// 交易密码
        /// </summary>
        public int DealPwd { get; set; }
        /// <summary>
        /// 身份证账号
        /// </summary>

        public string IdentityId { get; set; }
        /// <summary> 
        /// 银行卡号
        /// </summary>
        public string BankCard { get; set; }
    }
}
