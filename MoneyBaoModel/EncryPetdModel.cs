using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyBaoModel
{
    /// <summary>
    /// 密保表
    /// </summary>
    public class EncryPetdModel
    {
        /// <summary>
        /// 密保Id
        /// </summary>
        [Display(Name ="密保Id")]
        public int EncryPetdId { get; set; }
        /// <summary>
        /// 密保问题
        /// </summary>
        [Display(Name = "密保问题")]
        public string EncryPetdQuestion { get; set; }
    }
}
