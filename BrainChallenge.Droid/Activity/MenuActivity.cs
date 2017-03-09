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
    [Activity(Label = "MenuActivity", MainLauncher = true, Icon = "@drawable/icon")]
    public class MenuActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
			SetTheme(AppConst.targetTheme);
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Menu);

			var selectMemoryGameButton = FindViewById<Button>(Resource.Id.selectMemoryGameButton);
			selectMemoryGameButton.Click += delegate
			{
				var next = new Intent(this, typeof(GameStartActivity));
				next.PutExtra("MyData", "MemoryGameActivity");
				StartActivity(next);
			};

			var selectFlexibilityGameButton = FindViewById<Button>(Resource.Id.selectFlexibilityGameButton);
			selectFlexibilityGameButton.Click += delegate
			{
				var next = new Intent(this, typeof(GameStartActivity));
				next.PutExtra("MyData", "FlexibilityGameActivity");
				StartActivity(next);
			};


			var selectComputationalGameButton = FindViewById<Button>(Resource.Id.selectComputationalGameButton);
			selectComputationalGameButton.Click += delegate
			{
				var next = new Intent(this, typeof(GameStartActivity));
				next.PutExtra("MyData", "ComputationalGameActivity");
				StartActivity(next);
			};
        }
    }
}