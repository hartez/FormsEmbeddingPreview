using System;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using TipCalc;
using Xamarin.Forms;
using Button = Android.Widget.Button;
using TextChangedEventArgs = Android.Text.TextChangedEventArgs;
using View = Android.Views.View;

namespace FormsEmbeddingPreview.Droid
{
	public class MainFragment : Fragment
	{
		private double _initialAmount;
		private double _lastTipAmount;
		private bool _subscribed;

		private void SubscribeToTipMessages()
		{
			if (_subscribed)
			{
				return;
			}

			MessagingCenter.Subscribe<object, TipArgs>(Messages.Sender, Messages.Tip,
				(obj, args) =>
				{
					_lastTipAmount = args.Tip;
				});

			_subscribed = true;
		}

		protected MainFragment(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
		{
			SubscribeToTipMessages();
		}

		public MainFragment()
		{
			SubscribeToTipMessages();
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view =  inflater.Inflate(Resource.Layout.MainFragment, container, false);

			var tipCalcButton = view.FindViewById<Button>(Resource.Id.navigateToTipCalc);
			tipCalcButton.Click += TipCalcButtonOnClick;

			var initialAmount = view.FindViewById<EditText>(Resource.Id.initialAmount);
			initialAmount.TextChanged += InitialAmountOnTextChanged;

			var tipAmount = view.FindViewById<TextView>(Resource.Id.tipAmount);
			tipAmount.Text = _lastTipAmount.ToString("C");

			return view;
		}

		private void InitialAmountOnTextChanged(object sender, TextChangedEventArgs textChangedEventArgs)
		{
			double result;

			if (double.TryParse(textChangedEventArgs.Text.ToString(), out result))
			{
				_initialAmount = result;
			}
		}

		private void TipCalcButtonOnClick(object sender, EventArgs eventArgs)
		{
			((MainActivity)Activity).NavigateToTipCalc();

			MessagingCenter.Send(Messages.Sender, Messages.InitialAmount, 
				new InitialAmountArgs(_initialAmount));
		}
	}
}