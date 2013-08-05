using System;
using Core.Android.Models;
using System.Collections.Generic;
using SQLite;
using System.Linq.Expressions;

namespace Core.Android.Data
{
	public class SqliteAPI : IDataAccess {
		private SQLiteConnectionPool pool;
		private string connStr;

		public SqliteAPI (string connStr) {
			this.pool = new SQLiteConnectionPool ();
			this.connStr = connStr;
		}

		public async List<Visit> getVisits (Expression<Func<Visit, bool>> predicate) {
			SQLiteAsyncConnection conn = this.pool.GetConnection (this.connStr);
			return await conn.Table<Visit> ().Where (predicate).ToListAsync ();
		}

		void addVisit (Visit visit, Delegate cb) {
			SQLiteAsyncConnection conn = this.pool.GetConnection (this.connStr);
			if (visit.ID) {
				conn.UpdateAsync (visit).ContinueWith (t => cb (t.Result));
			}
			else {
				conn.InsertAsync (visit).ContinueWith (t => cb (t.Result));
			}
		}

		void deleteVisit (Expression<Func<Visit, bool>> predicate, Delegate cb) {
			SQLiteAsyncConnection conn = this.pool.GetConnection (this.connStr);
			conn.DeleteAsync ().ContinueWith (t => cb (t.Result));
		}
	}
