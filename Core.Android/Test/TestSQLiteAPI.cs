using System;
using System.Collections.Generic;
using System.Linq;
using Core.Android.Data;

namespace Core.Android.Test
{
	[TestFixture]
	class TestSQLiteAPI {
		private SQLiteAPI api;
		private const string connStr = "Data Source=c:\\temp\\wwe.db;Version=3;";

		[SetUp]
		public static void Init(){
			this.api = new SQLiteAPI (connStr);
		}

		[Test]
		public static void TestVisits(){
		}
	}
}

