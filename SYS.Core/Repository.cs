using MySql.Data.MySqlClient;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
    public class Repository:IRepository
    {
		private static string conStr = "";

		private static MySqlConnection con = null;

		public static MySqlConnection GetConnection()
		{
			if (con == null || con.ConnectionString == "")
			{
				con = new MySqlConnection(conStr);
			}
			return con;
		}

		public static void Opencon()
		{
			if (con.State == ConnectionState.Closed)
			{
				con.Open();
			}
		}

		public static void Closecon()
		{
			if (con.State == ConnectionState.Open)
			{
				con.Close();
			}
		}

		public int ExecuteSql(string sql, params DbParameter[] pars)
		{
			return 0;
		}

		public List<TT> ExecuteQuery<TT>(string sql, params DbParameter[] pars)
		{
			return List<TT>;
		}

		public int Add(T entity, bool isLog = true)
		{
			return 0;
		}

		public int Add(IEnumerable<T> entities, bool isLog = true)
		{
			return 0;

		}

		public int Delete(T entity, bool isLog = true)
		{
			return 0;
		}

		public int Delete(IEnumerable<T> entities, bool isLog = true)
		{
			return 0;
		}

		public int Delete(Expression<Func<T, bool>> where, bool isLog = true)
		{
			return 0;
		}

		public int Update(T entity, bool isLog = true)
		{
			return 0;
		}

		public int Update(T entity, List<Expression<Func<T, object>>> ignoreProperties, bool isLog = true)
		{
			return 0;
		}

		public int Update(T entity, Expression<Func<T, bool>> where, List<string> proNames, bool isLog = true)
		{
			return 0;
		}

		public int Update(T entity, Expression<Func<T, bool>> where, List<Expression<Func<T, object>>> proNames, bool isLog = true)
		{
			return 0;
		}

		public int Update(Expression<Func<T, bool>> where, Action<T> action, bool isLog = true)
		{
			return 0;
		}

		public T GetOne(Expression<Func<T, bool>> where)
		{
			return 0;
		}

		public List<T> GetList(Expression<Func<T, bool>> where = null)
		{

		}

		int GetCount(Expression<Func<T, bool>> where = null)
		{

		}
	}
}
