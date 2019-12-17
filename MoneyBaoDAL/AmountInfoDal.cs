using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoModel;
using System.Data;
using System.Data.SqlClient;
namespace MoneyBaoDAL
{
    /// <summary>
    /// 项目表
    /// </summary>
    public class AmountInfoDal
    {
       
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
       public int AddAmountInfo(AmountInfoModel model)
        {         
            string sql = $"insert into AmountInfo(AmountName,AmountSerial,ApplyMoney,AmountMoney,InterestRate,FinanceTime,RapayMentTime,FinanceUser,AmountState,CreateTime) values({model.AmountName},{model.AmountSerial},{model.ApplyMoney},{model.AmountMoney},{model.InterestRate},{model.FinanceTime},{model.RapayMentTime},{model.FinanceUser},{model.AmountState},{model.CreateTime})";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        ///  修改投资的人数、以及投资金额 投资人数自动加一
        /// </summary>
        /// <param name="AmountMoney">投资金额</param>
        /// <param name="AmountId">项目Id</param>
        /// <returns></returns>
        public int UpdateInvestorCount(Double AmountMoney,int AmountId)
        {
            string sql = $"update AmountInfo  set  InvestorCount=InvestorCount+1,set AmountMoney=AmountMoney+{AmountMoney} where AmountId={AmountId}";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改投资人的身份、抵押物、抵押物证明、联系人手机号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateAmountInfo(AmountInfoModel model)
        {
            string sql = $"update AmountInfo set IdentityFornt={model.IdentityFornt},IdentityReal={model.IdentityReal},Guarante={model.Guarantee},GuaranteeInfo={model.GuaranteeInfo},LinkManNumber={model.LinkManNumber} where AmountId={model.AmountId}";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 显示项目表
        /// </summary>
        public List<AmountInfoModel> ShowAmountInfo()
        {
            return PubilcHelper.DBHelper.GetToList<AmountInfoModel>("select * fromv AmountInfo").ToList();
        }
    }
}
