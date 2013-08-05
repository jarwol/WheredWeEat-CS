using System;

namespace Core.Android.Models
{
	public class Item : BaseModel {
		public string Name{ get; set; }

		public ItemType Type{ get; set; }

		public string Description{ get; set; }
	}

	public enum ItemType {
		Food,
		Drink,
		Other
	}
}

