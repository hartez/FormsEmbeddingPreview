using System;
using Android.App;
using Android.OS;
using Android.Support.V4.App;
using FormsEmbeddingPreview;
using FormsEmbeddingPreview.Droid;
using TipCalc;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;
using Fragment = Android.Support.V4.App.Fragment;
using Button = Android.Widget.Button;
using Resource = FormsEmbeddingPreview.Droid.Resource;

namespace FormsEmbeddingPreview.Droid
{
	[Activity(Label = "FormsEmbedding.Droid", MainLauncher = true)]
	public class MainActivity : FragmentActivity
	{
		Fragment _tipCalc;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Before the first time we use it, we need to initialize Xamarin.Forms
			Forms.Init(this, null);

			SetContentView(Resource.Layout.Main);

			var ft = SupportFragmentManager.BeginTransaction();
			ft.Replace(Resource.Id.fragment_frame_layout, new MainFragment(), "main");
			ft.Commit();
		}

		public void NavigateToTipCalc()
		{
			if (_tipCalc == null)
			{
				_tipCalc = new TipCalcPage().CreateSupportFragment(this);
			}

			var ft = SupportFragmentManager.BeginTransaction();

			ft.AddToBackStack(null);
			ft.Replace(Resource.Id.fragment_frame_layout, _tipCalc, "TipCalc");
			
			ft.Commit();
		}
	}
}

