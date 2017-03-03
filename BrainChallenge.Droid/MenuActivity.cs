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
    [Activity(Theme = "@android:style/Theme.Light.NoTitleBar", Label = "MenuActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Menu);
			//
            // Create your application here
			var button = FindViewById<Button>(Resource.Id.button);
			button.Click += delegate
			{
				var activity2 = new Intent(this, typeof(GameStartActivity));
				activity2.PutExtra("MyData", "Data from Activity1");
				StartActivity(activity2);
			};
        }
    }
}