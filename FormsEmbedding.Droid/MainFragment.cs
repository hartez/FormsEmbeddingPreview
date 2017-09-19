using System;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace FormsEmbeddingPreview.Droid
{
	public class MainFragment : Fragment
	{
		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view =  inflater.Inflate(Resource.Layout.MainFragment, container, false);

			var tipCalcButton = view.FindViewById<Button>(Resource.Id.navigateToTipCalc);
			tipCalcButton.Click += TipCalcButtonOnClick;

			return view;
		}

		private void TipCalcButtonOnClick(object sender, EventArgs eventArgs)
		{
			((MainActivity)Activity).NavigateToTipCalc();
		}
	}
}