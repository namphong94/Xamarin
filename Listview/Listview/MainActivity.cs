using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Listview
{
	[Activity (Label = "Listview", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);
		

			var countriesAdapter = new CountryAdapter (this);
			var countriesListView = FindViewById<ListView> (Resource.Id.CountryViewList);
			countriesListView.Adapter = countriesAdapter;
		}
	}
}


