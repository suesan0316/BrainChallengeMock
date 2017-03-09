using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace BrainChallenge.Droid
{
	[Activity(Label = "GameResultActivity")]
	public class GameResultActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			SetTheme(AppConst.targetTheme);

			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.GameResult);

			var returnButton = FindViewById<Button>(Resource.Id.returnButton);
			returnButton.Click += delegate
			{
				var next = new Intent(this, typeof(MenuActivity));
				next.PutExtra("MyData", "Data from Activity1");
				StartActivity(next);
			};

			var againButton = FindViewById<Button>(Resource.Id.againButton);

			againButton.Click += delegate {
				var next = new Intent(this, typeof(MemoryGameActivity));
				next.PutExtra("MyData", "Data from Activity1");
				StartActivity(next);
			};
		}
	}
}
