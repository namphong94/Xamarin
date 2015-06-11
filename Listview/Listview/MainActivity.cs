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
		private List<Country> myCountryList;
		private ListView mListView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);
		
			mListView = FindViewById<ListView>(Resource.Id.myListView);

			Country Vietnam;
			Vietnam.Name = "Vietnam";
			Vietnam.Capital = "Hanoi";
			Vietname.Flag = 
	
			myCountryList = new List<Country> ();
			myCountryList.Add(
			myCountryList.Add("Australia");
			myCountryList.Add ("Canada");
			myCountryList.Add("China");
			myCountryList.Add("Japan");
			myCountryList.Add("Belgium");

			ListAdapter = new CountryAdapter(this, items);

			mListView.Adapter = adapter;
		}
	}
}


