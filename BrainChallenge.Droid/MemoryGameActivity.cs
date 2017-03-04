﻿
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
	[Activity(Theme = "@android:style/Theme.Light.NoTitleBar",Label = "MemoryGameActivity")]
	public class MemoryGameActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.MemoryGame);

			// Create your application here
			var returnButton = FindViewById<Button>(Resource.Id.button21);
			returnButton.Click += delegate {
				var activity2 = new Intent(this, typeof(GameResultActivity));
				StartActivity(activity2);
			};

			var startButton = FindViewById<Button>(Resource.Id.button22);

			startButton.Click += delegate
			{
				for (int i = 1; i <= 20; i++)
				{
					var res = FindViewById<TextView>(Resource.Id.textView2);
					var index = Resources.GetIdentifier("button"+i, "id", this.PackageName);
					var button = FindViewById<Button>(index);
					if (button.Text.Equals("O"))
					{
						button.Click += delegate
						{
							button.Text = "O";
							res.Text = "あたり！";
						};
					}
					else
					{
						button.Click += delegate {
							button.Text = "X";
							res.Text = "はずれ...";
						};
					}

					button.Text = "";
				}
			};

		}
	}
}
