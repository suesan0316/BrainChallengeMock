
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
	[Activity(Label = "ComputationalGameActivity")]
	public class ComputationalGameActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			this.SetTheme(AppConst.targetTheme);

			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.ComputationalGame);

			// Create your application here

			// Create your application here
			var returnButton = FindViewById<Button>(Resource.Id.button3);
			returnButton.Click += delegate
			{
				var activity2 = new Intent(this, typeof(GameResultActivity));
				StartActivity(activity2);
			};
		}
	}
}
