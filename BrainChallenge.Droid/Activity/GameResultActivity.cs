
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
	[Activity(Theme = "@android:style/Theme.Light.NoTitleBar",Label = "GameResultActivity")]
	public class GameResultActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.GameResult);
			var button = FindViewById<Button>(Resource.Id.button4);
			button.Click += delegate
			{
				var activity2 = new Intent(this, typeof(MenuActivity));
				activity2.PutExtra("MyData", "Data from Activity1");
				StartActivity(activity2);
			};

			var again = FindViewById<Button>(Resource.Id.button1);

			again.Click += delegate {
				var activity2 = new Intent(this, typeof(MemoryGameActivity));
				activity2.PutExtra("MyData", "Data from Activity1");
				StartActivity(activity2);
			};

			// Create your application here
		}
	}
}
