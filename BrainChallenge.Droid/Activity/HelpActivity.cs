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
	[Activity(Label = "HelpActivity")]
	public class HelpActivity : Activity
	{
		MyPagerCatalog treeCatalog;
		protected override void OnCreate(Bundle savedInstanceState)
		{
			this.SetTheme(AppConst.targetTheme);
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Help);

			// Locate the ViewPager:
			MyPager viewPager = FindViewById<MyPager>(Resource.Id.viewpager);

			// Instantiate the tree catalog:
			treeCatalog = new MyPagerCatalog();

			// Set up the adapter for the ViewPager
			viewPager.Adapter = new MyPagerAdapter(this, treeCatalog);

			var button = FindViewById<Button>(Resource.Id.button1);
			button.Click += delegate
			{
				var activity2 = new Intent(this, typeof(GameStartActivity));
				StartActivity(activity2);
			};

			viewPager.PageSelected += delegate {
				int dat = viewPager.CurrentItem;
				var text = FindViewById<TextView>(Resource.Id.textView2);

				text.Text = "ゲームのヘルプ"+(dat + 1)+"です\nゲームの説明を表示";
			};
		}
	}
}
