
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
	[Activity(Label = "GameStartActivity")]
	public class GameStartActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			SetTheme(AppConst.targetTheme);

			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.GameStart);

			var returnButton = FindViewById<Button>(Resource.Id.returnButton);
			returnButton.Click += delegate
			{
				var next = new Intent(this, typeof(MenuActivity));
				StartActivity(next);
			};

			string nextInfo = Intent.GetStringExtra("MyData") ?? "Data not available";

			var gameStartButton = FindViewById<Button>(Resource.Id.gameStartButton);
			gameStartButton.Click += delegate
			{
				var next = new Intent(this, Type.GetType("BrainChallenge.Droid." + nextInfo));
				StartActivity(next);
			};

			var helpButton = FindViewById<Button>(Resource.Id.helpButton);
			helpButton.Click += delegate
			{
				var next = new Intent(this, typeof(HelpActivity));
				StartActivity(next);
			};
		}
	}
}
