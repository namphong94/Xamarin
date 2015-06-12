using System;
using Android.Widget;
using System.Collections.Generic;
using Android.App;
using Android.Views;

namespace Listview
{
	public class CountryAdapter : BaseAdapter
	{
		private List<Country> ListCountry;
		Activity _activity;

		public CountryAdapter (Activity activity)
		{
			_activity = activity;
			FillCountries ();
		}

		void FillCountries ()
		{
			Country Vietnam = new Country ();
			Vietnam.Name = "Vietnam";
			Vietnam.Capital = "Hanoi";
			Vietnam.PhotoId = Resource.Drawable.b31;

			Country Australia = new Country ();
			Australia.Name = "Australia";
			Australia.Capital = "Canberra";
			Australia.PhotoId = Resource.Drawable.australia;

			Country China = new Country ();
			China.Name = "China";
			China.Capital = "Beijing";
			China.PhotoId = Resource.Drawable.china;

			Country Japan = new Country ();
			Japan.Name = "Japan";
			Japan.Capital = "Tokyo";
			Japan.PhotoId = Resource.Drawable.japan;

			Country Canada = new Country ();
			Canada.Name = "Canada";
			Canada.Capital = "Ottawa";
			Canada.PhotoId = Resource.Drawable.Canada;

			Country Belgium = new Country ();
			Belgium.Name = "Belgium";
			Belgium.Capital = "Bruxelles";
			Belgium.PhotoId = Resource.Drawable.belgium;



			ListCountry = new List<Country> ();

			ListCountry.Add (Vietnam);
			ListCountry.Add (Australia);
			ListCountry.Add (China);
			ListCountry.Add (Japan);
			ListCountry.Add (Canada);
			ListCountry.Add (Belgium);

		}
			
		public override int Count
		{
			get { return ListCountry.Count; }
		}

		public override Java.Lang.Object GetItem (int position) {
			// could wrap a Contact in a Java.Lang.Object
			// to return it here if needed
			return ListCountry[position];
		}

		public override long GetItemId (int position) {
			return  position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			
			ViewHolder holder;

			if (convertView == null)
			{
				convertView = _activity.LayoutInflater.Inflate(Resource.Layout.CountryListItem, null);
				holder = new ViewHolder();
				holder.counreyNameTextView = (TextView) convertView.FindViewById(Resource.Id.CountryName);
				holder.capitalNameTextView = (TextView) convertView.FindViewById(Resource.Id.Capital);
				holder.flagImageView = (ImageView) convertView.FindViewById(Resource.Id.FlagImage);
				convertView.Tag = holder;
			}

			else
			{
				holder = (ViewHolder) convertView.Tag;
			}

			Country country = (Country) GetItem(position);

			holder.counreyNameTextView.Text = country.Name;
			holder.capitalNameTextView.Text = country.Capital;
			holder.flagImageView.SetImageResource(country.PhotoId);
		
			return convertView;
		}


		class Country : Java.Lang.Object
		{
			public string Name { get; set; }
			public string Capital{ get; set; }
			public int PhotoId { get; set; }
		}

		private class ViewHolder : Java.Lang.Object
		{
			public TextView counreyNameTextView;
			public TextView capitalNameTextView;
			public ImageView flagImageView;

		}

	}


}

