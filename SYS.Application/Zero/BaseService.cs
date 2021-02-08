using MySql.Data.MySqlClient;
using SYS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Application
{
    /// <summary>
    /// 基础信息接口实现类
    /// </summary>
    public class BaseService: IBaseService
    {

        #region 性别模块
        /// <summary>
        /// 查询所有性别类型
        /// </summary>
        /// <returns></returns>
        public List<SexType> SelectSexTypeAll()
        {
            List<SexType> sexTypes = new List<SexType>();
            string sql = "select * from sextype";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                SexType type = new SexType();
                type.sexId = (int)dr["sexId"];
                type.sexName = dr["sexName"].ToString();
                type.delete_mk = (int)dr["delete_mk"];
                sexTypes.Add(type);
            }
            dr.Close();
            DBHelper.Closecon();
            return sexTypes;
        }

        /// <summary>
        /// 查询性别类型
        /// </summary>
        /// <returns></returns>
        public SexType SelectSexType(SexType sexType)
        {
            sexType = new SexType();
            string sql = string.Format("select * from sextype where sexId = {0}", sexType.sexId);
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                sexType.sexId = (int)dr["sexId"];
                sexType.sexName = dr["sexName"].ToString();
                sexType.delete_mk = (int)dr["delete_mk"];
            }
            dr.Close();
            DBHelper.Closecon();
            return sexType;
        }

        /// <summary>
        /// 添加性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int AddSexType(SexType sexType)
        {
            string sql = string.Format("insert into sexType values('{0}','{1}')", sexType.sexId, sexType.sexName);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int DelSexType(SexType sexType)
        {
            string sql = string.Format("update sexType set delete_mk = 1 where sexId = '[0]'", sexType.sexId);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 更新性别类型
        /// </summary>
        /// <param name="sexType"></param>
        /// <returns></returns>
        public int UpdSexType(SexType sexType)
        {
            string sql = string.Format("update sexType set sexName = '{1}' where sexId = '[0]'", sexType.sexId,sexType.sexName);
            return DBHelper.ExecuteNonQuery(sql);
        }

        #endregion

        #region 职位模块

        /// <summary>
        /// 查询所有职位类型
        /// </summary>
        /// <returns></returns>
        public List<Position> SelectPositionAll()
        {
            List<Position> positions = new List<Position>();
            string sql = "select * from position";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Position position = new Position() 
                {
                    position_no = dr["position_no"].ToString(),
                    position_name = dr["position_name"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
                positions.Add(position);
            }
            dr.Close();
            DBHelper.Closecon();
            return positions;
        }

        /// <summary>
        /// 查询职位类型
        /// </summary>
        /// <returns></returns>
        public Position SelectPosition(Position position)
        {
            Position position1 = new Position();
            string sql = string.Format("select * from position where position_no = '{0}'",position.position_no);
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                position1 = new Position()
                {
                    position_no = dr["position_no"].ToString(),
                    position_name = dr["position_name"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
            }
            dr.Close();
            DBHelper.Closecon();
            return position1;
        }

        /// <summary>
        /// 添加职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int AddPosition(Position position)
        {
            string sql = string.Format("insert into position(position_no,position_name,datains_usr,datains_date) values('{0}','{1}','{2}','{3}')"
                , position.position_no,position.position_name,position.datains_usr,position.datains_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int DelPosition(Position position)
        {
            string sql = string.Format("update position set delete_mk = 1,datachg_usr = '{1}',datachg_date = '{2}' where position_no = '{0}')"
                , position.position_no, position.datachg_usr, position.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 更新职位类型
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public int UpdPosition(Position position)
        {
            string sql = string.Format("update position set position_name = '{1}',datachg_usr = '{2}',datachg_date = '{3}' where position_no = '{0}')"
                , position.position_no, position.position_name,position.datachg_date,position.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        #endregion

        #region 民族模块

        /// <summary>
        /// 查询所有民族类型
        /// </summary>
        /// <returns></returns>
        public List<Nation> SelectNationAll()
        {
            List<Nation> nations = new List<Nation>();
            string sql = "select * from nation where delete_mk = 0";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Nation nation = new Nation()
                {
                    nation_no = dr["nation_no"].ToString(),
                    nation_name = dr["nation_name"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
                nations.Add(nation);
            }
            dr.Close();
            DBHelper.Closecon();
            return nations;
        }

        /// <summary>
        /// 查询民族类型
        /// </summary>
        /// <returns></returns>
        public Nation SelectNation(Nation nation)
        {
            Nation nation1 = new Nation();
            string sql = string.Format("select * from nation where nation_no = '{0}'", nation.nation_no);
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                nation1 = new Nation()
                {
                    nation_no = dr["nation_no"].ToString(),
                    nation_name = dr["nation_name"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
            }
            dr.Close();
            DBHelper.Closecon();
            return nation1;
        }

        /// <summary>
        /// 添加民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public int AddNation(Nation nation)
        {
            string sql = string.Format("insert into nation(nation_no,nation_name,datains_usr,datains_date) values('{0}','{1}','{2}','{3}')"
                , nation.nation_no, nation.nation_name, nation.datains_usr, nation.datains_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public int DelNation(Nation nation)
        {
            string sql = string.Format("update nation set delete_mk = 1,datachg_usr = '{1}',datachg_date = '{2}' where nation_no = '{0}'"
                , nation.nation_no, nation.datachg_usr, nation.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 更新民族类型
        /// </summary>
        /// <param name="nation"></param>
        /// <returns></returns>
        public int UpdNation(Nation nation)
        {
            string sql = string.Format("update nation set nation_name = '{1}',datachg_usr = '{2}',datachg_date = '{3}' where nation_no = '{0}')"
                , nation.nation_no, nation.nation_name, nation.datachg_date, nation.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        #endregion

        #region 学历模块

        /// <summary>
        /// 查询所有学历类型
        /// </summary>
        /// <returns></returns>
        public List<Education> SelectEducationAll()
        {
            List<Education> educations = new List<Education>();
            string sql = "select * from Education";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Education education = new Education()
                {
                    education_no = dr["education_no"].ToString(),
                    education_name = dr["education_name"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
                educations.Add(education);
            }
            dr.Close();
            DBHelper.Closecon();
            return educations;
        }

        /// <summary>
        /// 查询学历类型
        /// </summary>
        /// <returns></returns>
        public Education SelectEducation(Education education)
        {
            Education education1 = new Education();
            string sql = string.Format("select * from education where education_no = '{0}'", education.education_no);
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                education1 = new Education()
                {
                    education_no = dr["education_no"].ToString(),
                    education_name = dr["education_name"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
            }
            dr.Close();
            DBHelper.Closecon();
            return education1;
        }

        /// <summary>
        /// 添加学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public int AddEducation(Education education)
        {
            string sql = string.Format("insert into education(education_no,education_name,datains_usr,datains_date) values('{0}','{1}','{2}','{3}')"
                , education.education_no, education.education_name, education.datains_usr, education.datains_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public int DelEducation(Education education)
        {
            string sql = string.Format("update education set delete_mk = 1,datachg_usr = '{1}',datachg_date = '{2}' where education_no = '{0}')"
                , education.education_no, education.datachg_usr, education.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 更新学历类型
        /// </summary>
        /// <param name="education"></param>
        /// <returns></returns>
        public int UpdEducation(Education education)
        {
            string sql = string.Format("update education set education_name = '{1}',datachg_usr = '{2}',datachg_date = '{3}' where education_no = '{0}')"
                , education.education_no, education.education_name, education.datachg_date, education.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        #endregion

        #region 部门模块

        /// <summary>
        /// 查询所有部门类型
        /// </summary>
        /// <returns></returns>
        public List<Dept> SelectDeptAll()
        {
            List<Dept> depts = new List<Dept>();
            string sql = "select * from Dept";
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                Dept dept = new Dept()
                {
                    dept_no = dr["dept_no"].ToString(),
                    dept_name = dr["dept_name"].ToString(),
                    dept_desc = dr["dept_desc"].ToString(),
                    dept_leader = dr["dept_leader"].ToString(),
                    dept_date = Convert.ToDateTime(dr["dept_date"]),
                    dept_parent = dr["dept_parent"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
                depts.Add(dept);
            }
            dr.Close();
            DBHelper.Closecon();
            return depts;
        }

        /// <summary>
        /// 查询部门类型
        /// </summary>
        /// <returns></returns>
        public Dept SelectDept(Dept dept)
        {
            Dept dept1 = new Dept();
            string sql = string.Format("select * from dept where dept_no = '{0}'", dept.dept_no);
            MySqlDataReader dr = DBHelper.ExecuteReader(sql);
            while (dr.Read())
            {
                dept1 = new Dept()
                {
                    dept_no = dr["dept_no"].ToString(),
                    dept_name = dr["dept_name"].ToString(),
                    dept_desc = dr["dept_desc"].ToString(),
                    dept_leader = dr["dept_leader"].ToString(),
                    dept_date = Convert.ToDateTime(dr["dept_date"]),
                    dept_parent = dr["dept_parent"].ToString(),
                    delete_mk = (int)dr["delete_mk"],
                    datains_usr = dr["datains_usr"].ToString(),
                    datains_date = Convert.ToDateTime(dr["datains_date"]),
                    datachg_usr = dr["datachg_usr"].ToString(),
                    datachg_date = Convert.ToDateTime(dr["datachg_date"]),
                };
            }
            dr.Close();
            DBHelper.Closecon();
            return dept1;
        }

        /// <summary>
        /// 添加部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int AddDept(Dept dept)
        {
            string sql = string.Format("insert into dept(dept_no,dept_name,dept_desc,dept_date,dept_leader,dept_parent,datains_usr,datains_date)" +
                " values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')"
                , dept.dept_no, dept.dept_name, dept.dept_desc, dept.dept_date, dept.dept_leader, dept.dept_parent, dept.datains_usr, dept.datains_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 删除部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int DelDept(Dept dept)
        {
            string sql = string.Format("update dept set delete_mk = 1,datachg_usr = '{1}',datachg_date = '{2}' where dept_no = '{0}')"
                , dept.dept_no, dept.datachg_usr, dept.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 更新部门类型
        /// </summary>
        /// <param name="dept"></param>
        /// <returns></returns>
        public int UpdDept(Dept dept)
        {
            string sql = string.Format("update dept set dept_name = '{1}',dept_desc = '{2}',dept_date = '{3}',dept_leader = '{4}',dept_parent = '{5}',datachg_usr = {6},datachg_date = {7} where dept_no = '{0}')"
                , dept.dept_no, dept.dept_name, dept.dept_desc, dept.dept_date, dept.dept_leader, dept.dept_parent, dept.datachg_usr, dept.datachg_date);
            return DBHelper.ExecuteNonQuery(sql);
        }

        #endregion
    }
}
