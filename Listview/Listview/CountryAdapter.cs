using System;
using Android.Widget;
using System.Collections.Generic;
using Android.App;
using Android.Views;

namespace Listview
{
	public class CountryAdapter : BaseAdapter
	{
		List<Country> _countryList;
		Activity _activity;

		public CountryAdapter (Activity activity)
		{
			_activity = activity;
			FillContacts ();
		}

		void FillContacts ()
		{
			var uri = ContactsContract.Contacts.ContentUri;

			string[] projection = {
				ContactsContract.Contacts.InterfaceConsts.Id,
				ContactsContract.Contacts.InterfaceConsts.DisplayName,
				ContactsContract.Contacts.InterfaceConsts.PhotoId
			};

			var cursor = _activity.ManagedQuery (uri, projection, null,
				null, null);

			_countryList = new List<Country> ();

			if (cursor.MoveToFirst ()) {
				do {
					_countryList.Add (new Country{Name = cursor.GetString (cursor.GetColumnIndex (projection [0])),
												Capital = cursor.GetString (cursor.GetColumnIndex (projection [1])),
												PhotoId = cursor.GetString (cursor.GetColumnIndex (projection [2]))
					});
				} while (cursor.MoveToNext());
			}
		}

		class Country
		{
			public string Name { get; set; }
			public string Capital{ get; set; }
			public string PhotoId { get; set; }
		}
	}


	}
}

