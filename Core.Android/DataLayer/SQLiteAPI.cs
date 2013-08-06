using System;
using Core.Android.Models;
using System.Collections.Generic;
using SQLite;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Android.Data {
	public class SQLiteAPI : IDataAccess {
		private static SQLiteAPI INSTANCE;
		private string dbPath;

		public void Initialize(string dbPath){
			this.dbPath = dbPath;
		}

		private SQLiteAPI() {
		}

		public static SQLiteAPI Instance {
			get {
				if (INSTANCE == null) {
					INSTANCE = new SQLiteAPI();
				}
				return INSTANCE;
			}
		}

		public async Task<Dictionary<Type, int>> CreateTables() {
			SQLiteAsyncConnection conn = new SQLiteAsyncConnection(this.dbPath);
			var result = await conn.CreateTablesAsync<Visit, Friend, Item>();
			return result.Results;
		}

		public async Task<List<Visit>> GetVisits(Expression<Func<Visit, bool>> predicate) {
			SQLiteAsyncConnection conn = new SQLiteAsyncConnection(this.dbPath);
			return await conn.Table<Visit>().Where(predicate).ToListAsync();
		}

		public async Task<int> AddVisit(Visit visit) {
			SQLiteAsyncConnection conn = new SQLiteAsyncConnection(this.dbPath);
			if (visit.ID > 0) {
				return await conn.UpdateAsync(visit);
			}
			return await conn.InsertAsync(visit);
		}

		public async Task<int> DeleteVisit(Visit visit) {
			SQLiteAsyncConnection conn = new SQLiteAsyncConnection(this.dbPath);
			return await conn.DeleteAsync(visit);
		}
	}
}