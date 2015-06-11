using System;
using Android.Widget;
using Android.Views;

namespace Listview
{
	public class MyViewHolder : Java.Lang.Object
	{
		public TextView Name { get; set; }
		public TextView Description { get; set; }
		public ImageView Image { get; set; }

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			MyViewHolder holder;
			var view = convertView;
			if(view != null)
				holder = view.Tag as MyViewHolder;
			
			if (holder == null)
			{
				holder = new MyViewHolder ();
				view = activity.LayoutInflater.Inflate (Resource.Layout.OptimizedItem, null);
				holder.Name = view.FindViewById<TextView> (Resource.Id.textView1);
				holder.Description = view.FindViewById<TextView> (Resource.Id.textView2);
				holder.Image = view.FindViewById<ImageView> (Resource.Id.imageView);
				view.Tag = holder;
			}

			holder.Name.Text = Names [position];
			holder.Description.Text = Descriptions [position];
			holder.Image.SetImageResource (!Names [position].ToLower ().Contains ("xamarin") ? 
											Resource.Drawable.hexagopurple : Resource.Drawable.hexagongreen);
			return view;
		}
	}
}

