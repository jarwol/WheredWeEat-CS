using System;
using System.Collections.Generic;
using Core.Android.Models;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Android.Data {
	public interface IDataAccess {
		Task<Dictionary<Type, int>> CreateTables();

		Task<List<Visit>> GetVisits(Expression<Func<Visit, bool>> predicate);

		Task<int> AddVisit(Visit visit);

		Task<int> DeleteVisit(Visit visit);
	}
}
