using System;
using System.Collections.Generic;

namespace Core.Android.Models {
	public class Visit : BaseModel {
		private ISet<Item> items;
		private ISet<Friend> friends;

		public string Name { get; set; }

		public DateTime Date { get; set; }

		public string Comments{ get; set; }

		public ISet<Item> Items {
			get {
				return this.items;
			}
		}

		public ISet<Friend> Friends {
			get {
				return this.friends;
			}
		}

		public double Rating { get; set; }

		public Visit() {
			this.friends = new HashSet<Friend>();
			this.items = new HashSet<Item>();
		}
	}
}

