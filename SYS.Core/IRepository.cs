using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SYS.Common
{
	public interface IRepository<T> where T : class
	{
		int ExecuteSql(string sql, params DbParameter[] pars);

		List<TT> ExecuteQuery<TT>(string sql, params DbParameter[] pars);

		int Add(T entity, bool isLog = true);

		int Add(IEnumerable<T> entities, bool isLog = true);

		int Delete(T entity, bool isLog = true);

		int Delete(IEnumerable<T> entities, bool isLog = true);

		int Delete(Expression<Func<T, bool>> where, bool isLog = true);

		int Update(T entity, bool isLog = true);

		int Update(T entity, List<Expression<Func<T, object>>> ignoreProperties, bool isLog = true);

		int Update(T entity, Expression<Func<T, bool>> where, List<string> proNames, bool isLog = true);

		int Update(T entity, Expression<Func<T, bool>> where, List<Expression<Func<T, object>>> proNames, bool isLog = true);

		int Update(Expression<Func<T, bool>> where, Action<T> action, bool isLog = true);

		T GetOne(Expression<Func<T, bool>> where);

		List<T> GetList(Expression<Func<T, bool>> where = null);

		int GetCount(Expression<Func<T, bool>> where = null);

		//List<T> GetList(Expression<Func<T, bool>> where, OrderBy orderBy);

		//List<T> GetPageList(Expression<Func<T, bool>> where, OrderBy orderBy, int pageIndex = 0, int pageSize = 0);

		//List<T> GetPageList(ref int rowCount, Expression<Func<T, bool>> where, OrderBy orderBy, int pageIndex = 0, int pageSize = 0);

		//List<T> GetPageList<T2>(Expression<Func<T, bool>> where, OrderBy orderBy, T2 pageDto) where T2 : IBaseDto;

		//List<T> GetPageList<T2>(ref int rowCount, Expression<Func<T, bool>> where, OrderBy orderBy, T2 pageDto) where T2 : IBaseDto;
	}
}
