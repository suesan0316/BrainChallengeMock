
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BrainChallenge.Droid
{
	[Activity(Theme = "@android:style/Theme.Light.NoTitleBar", Label = "GameStartActivity")]
	public class GameStartActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.GameStart);
			var button = FindViewById<Button>(Resource.Id.button4);
			button.Click += delegate
			{
				var activity2 = new Intent(this, typeof(MenuActivity));
				activity2.PutExtra("MyData", "Data from Activity1");
				StartActivity(activity2);
			};

			var button1 = FindViewById<Button>(Resource.Id.button1);
			button1.Click += delegate
			{
				var activity2 = new Intent(this, typeof(MemoryGameActivity));
				activity2.PutExtra("MyData", "Data from Activity1");
				StartActivity(activity2);
			};

			var button3 = FindViewById<Button>(Resource.Id.button3);
			button3.Click += delegate
			{
				var activity2 = new Intent(this, typeof(HelpActivity));
				activity2.PutExtra("MyData", "Data from Activity1");
				StartActivity(activity2);
			};


			// Create your application here
		}
	}
}
