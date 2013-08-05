using System;
using System.Collections.Generic;
using Core.Android.Models;
using System.Linq.Expressions;

namespace Core.Android.Data
{
	public interface IDataAccess {
		void getVisits (Expression<Func<Visit, bool>> predicate, Delegate cb);

		void addVisit (Visit visit, Delegate cb);

		void deleteVisit (Expression<Func<Visit, bool>> predicate, Delegate cb);

		void getFriends (Expression<Func<Friend, bool>> predicate, Delegate cb);

		void addFriend (Friend friend, Delegate cb);

		void deleteFriend (Expression<Func<Visit, bool>> predicate, Delegate cb);
	}
}
