using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using MoneyBaoBll;
using MoneyBaoModel;
using Newtonsoft.Json;
namespace MoneyBaoAPI.Controllers
{
    /// <summary>
    /// 项目表  常雅俊
    /// </summary>
    public class AmountInfoController : ApiController
    {
        AmountInfoBll bll = new AmountInfoBll();
        /// <summary>
        /// 添加项目
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int PostAmountInfo(string json)
        {
            AmountInfoModel model = JsonConvert.DeserializeObject<AmountInfoModel>(json);
            return bll.AddAmountInfo(model);
        }
        /// <summary>
        /// 修改投资人的身份、抵押物、抵押物证明、联系人手机号
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int PutAmountInfo(AmountInfoModel model)
        {
            //接收文件
            HttpFileCollection file = HttpContext.Current.Request.Files;
            //判断非空
            if (file.Count >= 3)
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
                    num= bll.UpdateAmountInfo(model);
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
        public List<AmountInfoModel> GetAmountInfo(int AmountId=-1)
        {
            if (AmountId==-1)
            {
                return bll.ShowAmountInfo();
            }
            else
            {
                return bll.ShowAmountInfo().Where(s => s.AmountId == AmountId).ToList();
            }
        }
    }
}
