using System;
using SQLite;

namespace Core.Android
{
	/// <summary>
	/// Base business object class that provides a unique ID for each Model.
	/// </summary>
	public abstract class BaseModel {
		[PrimaryKey, AutoIncrement]
		public int ID{ get; set; }
	}
}

