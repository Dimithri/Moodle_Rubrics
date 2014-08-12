using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace test
{
	[Activity (Label = "test", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button> (Resource.Id.myButton);
			
		//	button.Click += delegate {
				//button.Text = string.Format ("{0} clicks!", count++);
		//	};

			Button continueButton = FindViewById<Button> (Resource.Id.continueButton);

			continueButton.Click += (object sender, EventArgs e) => {

				var intent = new Intent(this, typeof(ContinueActivity));
			};

		
		}
		public void navigateNext(){
			Intent intent = new Intent (this, typeof(ContinueActivity));
		}
		public void toContinue(View view){
			//Intent intent = new Intent(getApplicationContext(), ContinueActivity);

				StartActivity(typeof(ContinueActivity));

		}
	}
}



