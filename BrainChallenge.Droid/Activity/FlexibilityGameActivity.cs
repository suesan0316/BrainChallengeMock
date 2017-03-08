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
	[Activity(Theme = "@android:style/Theme.Light.NoTitleBar",Label = "FlexibilityGameActivity")]
	public class FlexibilityGameActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.FlexibilityGame);

			// Create your application here
		}
	}
}
