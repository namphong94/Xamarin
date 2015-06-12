package md5d2625e0cf31027a589526632c7a87261;


public class CountryAdapter_ViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Listview.CountryAdapter/ViewHolder, Listview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CountryAdapter_ViewHolder.class, __md_methods);
	}


	public CountryAdapter_ViewHolder () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CountryAdapter_ViewHolder.class)
			mono.android.TypeManager.Activate ("Listview.CountryAdapter/ViewHolder, Listview, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
