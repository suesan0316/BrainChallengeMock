using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.App;

namespace BrainChallenge.Droid
{
	[Activity(Theme = "@android:style/Theme.Light.NoTitleBar",Label = "HelpActivity")]
	public class HelpActivity : Activity
	{
		MyPagerCatalog treeCatalog;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Help);

			// Locate the ViewPager:
			ViewPager viewPager = FindViewById<ViewPager>(Resource.Id.viewpager);

			// Instantiate the tree catalog:
			treeCatalog = new MyPagerCatalog();

			// Set up the adapter for the ViewPager
			viewPager.Adapter = new MyPagerAdapter(this, treeCatalog);
		}
	}
}
