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
    public class AmountRecordController : ApiController
    {
        AmountRecordBll bll = new AmountRecordBll();
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int Post(AmountRecordModel model)
        {
            return bll.AddAmountRecord(model);
        }

        /// <summary>
        /// 显示记录
        /// </summary>
        /// <param name="CreateTime">创建时间</param>
        /// <param name="AmountState">状态</param>
        /// <param name="UserEmail">用户邮箱</param>
        /// <returns></returns>
        public ListPage<AmountRecordModel> Get(int page, int size, string CreateTime = "", int AmountState = -1, string UserEmail = "")
        {
            List<AmountRecordModel> dt= bll.Show(CreateTime,AmountState,UserEmail);
            ListPage<AmountRecordModel> list = new ListPage<AmountRecordModel>()
            {
                code = 0,
                msg = "msg",
                count = dt.Count,
                data = dt.Skip((page - 1) * size).Take(size).ToList()
            };
            return list;
        }
        /// <summary>
        /// 修改状态 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Put(int AmountState,int AmountId)
        {
            return bll.Update(AmountState, AmountId);
        }
    }
}
