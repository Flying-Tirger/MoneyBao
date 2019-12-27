using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyBaoModel;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.IO;

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
            string sql = $"insert into AmountInfo(AmountName,AmountSerial,ApplyMoney,AmountMoney,InterestRate,FinanceTime,RapayMentTime,FinanceUser,AmountState,CreateTime) values('{model.AmountName}','{model.AmountSerial}',{model.ApplyMoney},{model.AmountMoney},{model.InterestRate},{model.FinanceTime},{model.RapayMentTime},'{model.FinanceUser}',{model.AmountState},'{model.CreateTime}')";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        ///  修改投资的人数、以及投资金额 投资人数自动加一
        /// </summary>
        /// <param name="AmountMoney">投资金额</param>
        /// <param name="AmountId">项目Id</param>
        /// <returns></returns>
        public int UpdateInvestorCount(decimal AmountMoney,int AmountId)
        {
            string sql = $"update AmountInfo  set  InvestorCount=InvestorCount+1, AmountMoney=AmountMoney+{AmountMoney} where AmountId={AmountId}";
            return PubilcHelper.DBHelper.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改投资人的身份、抵押物、抵押物证明、联系人手机号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateAmountInfo(AmountInfoModel model)
        {
            //接收文件
            HttpFileCollection file = HttpContext.Current.Request.Files;
            //判断非空
            if (file.Count >=3 )
            {
               
                string str = Path.GetExtension(file[0].FileName).ToLower();
                string strTwo = Path.GetExtension(file[1].FileName).ToLower();
                string strTree = Path.GetExtension(file[2].FileName).ToLower();
                int num = 0;
                if (str.Equals(".jpg") || str.Equals(".png") || str.Equals(".gif"))
                {
                    string p = "/Content/Imgs/One" + Path.GetFileName(file[0].FileName);

                    file[0].SaveAs(HttpContext.Current.Server.MapPath(p));
                    num++;
                }
                if (strTwo.Equals(".jpg") || strTwo.Equals(".png") || strTwo.Equals(".gif"))
                {
                    string p = "/Content/Imgs/Two" + Path.GetFileName(file[1].FileName);

                    file[1].SaveAs(HttpContext.Current.Server.MapPath(p));
                    num++;
                }
                if (strTree.Equals(".jpg") || strTree.Equals(".png") || strTree.Equals(".gif"))
                {
                    string p = "/Content/Imgs/Tree" + Path.GetFileName(file[2].FileName);

                    file[2].SaveAs(HttpContext.Current.Server.MapPath(p));
                    num++;
                }
                if (num==3)
                {
                    string sql = $"update AmountInfo set AuditTime='{model.AuditTime}', IdentityFornt='{model.IdentityFornt}',IdentityReal='{model.IdentityReal}',Guarantee='{model.Guarantee}',GuaranteeInfo='{model.GuaranteeInfo}',LinkManNumber='{model.LinkManNumber}',InvestorCount='{model.InvestorCount}',AmountMoney='{model.AmountMoney}' where AmountId={model.AmountId}";
                    num= PubilcHelper.DBHelper.ExecuteNonQuery(sql);
                }
                return num;
              
            }
            else
            {
                return -1;

            }
        }
        /// <summary>
        /// 显示项目表
        /// </summary>
        public List<AmountInfoModel> ShowAmountInfo()
        {
            return PubilcHelper.DBHelper.GetToList<AmountInfoModel>("select * from AmountInfo");
        }
    }
}
