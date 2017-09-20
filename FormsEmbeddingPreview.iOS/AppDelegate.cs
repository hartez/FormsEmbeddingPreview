using System;
using Foundation;
using TipCalc;
using UIKit;
using Xamarin.Forms;

namespace FormsEmbeddingPreview.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public static AppDelegate Shared;
		public static UIStoryboard Storyboard = UIStoryboard.FromName("Main", null);

		UIViewController _tipCalc;
		UIWindow _window;
		UINavigationController _navigation;
		ViewController _mainController;

		internal double InitialAmount { get; set; }

		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Before the first time we use it, we need to initialize Xamarin.Forms
			Forms.Init();

			Shared = this;
			_window = new UIWindow(UIScreen.MainScreen.Bounds);

			_mainController = Storyboard.InstantiateInitialViewController() as ViewController;
			_navigation = new UINavigationController(_mainController);

			_window.RootViewController = _navigation;
			_window.MakeKeyAndVisible();

			return true;
		}

		public void NavigateToTipCalc()
		{
			if (_tipCalc == null)
			{
				_tipCalc = new TipCalcPage().CreateViewController();
			}

			MessagingCenter.Send(TipCalc.Messages.Sender, TipCalc.Messages.InitialAmount, 
				new InitialAmountArgs(InitialAmount));

			_navigation.PushViewController(_tipCalc, true);
		}
	}
}