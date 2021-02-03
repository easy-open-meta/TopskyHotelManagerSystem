using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SYS.Core;
using SYS.Application;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 员工奖惩信息控制器
    /// </summary>
    public class WorkerGoodBadController
    {
        /// <summary>
        /// 添加奖惩信息
        /// </summary>
        /// <param name="goodBad"></param>
        /// <returns></returns>
        public int AddGoodBad(WorkerGoodBad goodBad)
        {
            return WorkerGoodBadService.AddGoodBad(goodBad);
        }

        /// <summary>
        /// 根据员工编号查询奖惩信息
        /// </summary>
        /// <param name="wn"></param>
        /// <returns></returns>
        public List<WorkerGoodBad> SelectAllGoodBadByWorkNo(string wn)
        {
            return WorkerGoodBadService.SelectAllGoodBadByWorkNo(wn); 
        }
    }
}
