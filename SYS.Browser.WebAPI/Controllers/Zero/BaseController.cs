using SYS.Application;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SYS.Browser.WebAPI.Controllers
{
    /// <summary>
    /// 基础信息控制器
    /// </summary>
    public class BaseController: ApiController
    {
        #region 性别模块

        /// <summary>
        /// 查询所有性别类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<SexType> SelectSexTypeAll()
        {
            return new BaseService().SelectSexTypeAll();
        }

        /// <summary>
        /// 查询性别类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public SexType SelectSexType([FromUri]SexType sexType)
        {
            return new BaseService().SelectSexType(sexType);
        }

        /// <summary>
        /// 添加性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddSexType([FromBody]SexType sexType)
        {
            return new BaseService().AddSexType(sexType);
        }

        /// <summary>
        /// 删除性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DelSexType([FromBody]SexType sexType)
        {
            return new BaseService().DelSexType(sexType);
        }

        /// <summary>
        /// 更新性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        [HttpPost]
        public bool UpdSexType([FromBody]SexType sexType)
        {
            return new BaseService().UpdSexType(sexType);
        }

        #endregion

        #region 职位模块

        /// <summary>
        /// 查询所有职位类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Position> SelectPositionAll()
        {
            return new BaseService().SelectPositionAll();
        }

        /// <summary>
        /// 查询职位类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Position SelectPosition([FromUri]Position position)
        {
            return new BaseService().SelectPosition(position);
        }

        /// <summary>
        /// 添加职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddPosition([FromBody]Position position)
        {
            return new BaseService().AddPosition(position);
        }

        /// <summary>
        /// 删除职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DelPosition([FromBody]Position position)
        {
            return new BaseService().DelPosition(position);
        }

        /// <summary>
        /// 更新职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        [HttpPost]
        public bool UpdPosition([FromBody]Position position)
        {
            return new BaseService().UpdPosition(position);
        }

        #endregion

        #region 民族模块

        /// <summary>
        /// 查询所有民族类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Nation> SelectNationAll()
        {
            return new BaseService().SelectNationAll();
        }

        /// <summary>
        /// 查询民族类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Nation SelectNation([FromUri]Nation nation)
        {
            return new BaseService().SelectNation(nation);
        }

        /// <summary>
        /// 添加民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddNation([FromBody]Nation nation)
        {
            return new BaseService().AddNation(nation);
        }

        /// <summary>
        /// 删除民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DelNation([FromBody]Nation nation)
        {
            return new BaseService().DelNation(nation);
        }

        /// <summary>
        /// 更新民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        [HttpPost]
        public bool UpdNation([FromBody]Nation nation)
        {
            return new BaseService().UpdNation(nation);
        }

        #endregion

        #region 学历模块

        /// <summary>
        /// 查询所有学历类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Education> SelectEducationAll()
        {
            return new BaseService().SelectEducationAll();
        }

        /// <summary>
        /// 查询学历类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Education SelectEducation([FromUri]Education education)
        {
            return new BaseService().SelectEducation(education);
        }

        /// <summary>
        /// 添加学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddEducation([FromBody]Education education)
        {
            return new BaseService().AddEducation(education);
        }

        /// <summary>
        /// 删除学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DelEducation([FromBody]Education education)
        {
            return new BaseService().DelEducation(education);
        }

        /// <summary>
        /// 更新学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        [HttpPost]
        public bool UpdEducation([FromBody]Education education)
        {
            return new BaseService().UpdEducation(education);
        }

        #endregion

        #region 部门模块

        /// <summary>
        /// 查询所有部门类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Dept> SelectDeptAll()
        {
            return new BaseService().SelectDeptAll();
        }

        /// <summary>
        /// 查询部门类型
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public Dept SelectDept([FromUri]Dept dept)
        {
            return new BaseService().SelectDept(dept);
        }

        /// <summary>
        /// 添加部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        [HttpPost]
        public bool AddDept([FromBody]Dept dept)
        {
            return new BaseService().AddDept(dept);
        }

        /// <summary>
        /// 删除部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        [HttpDelete]
        public bool DelDept([FromBody]Dept dept)
        {
            return new BaseService().DelDept(dept);
        }

        /// <summary>
        /// 更新部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        [HttpPost]
        public bool UpdDept([FromBody]Dept dept)
        {
            return new BaseService().UpdDept(dept);
        }

        #endregion
    }
}
