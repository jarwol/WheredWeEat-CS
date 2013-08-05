using System;
using System.Collections.Generic;

namespace Core.Android.Models
{
	public class Visit : BaseModel {
		public string Name { get; set; }

		public DateTime Date { get; set; }

		public string Comments{ get; set; }

		public ISet<Item> Items{ get; }

		public ISet<Friend> Friends{ get; }

		public double Rating { get; set; }

		public Visit () {
			this.Friends = new HashSet<Friend> ();
			this.Items = new HashSet<string> ();
		}
	}
}

