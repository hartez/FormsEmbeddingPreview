using Foundation;
using System;
using TipCalc;
using UIKit;
using Xamarin.Forms;

namespace FormsEmbeddingPreview.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

	    public override void ViewDidLoad()
	    {
		    base.ViewDidLoad();

		    InitialAmount.EditingChanged += (sender, args) =>
		    {
			    double amount;
			    if (double.TryParse(InitialAmount.Text, out amount))
			    {
				    AppDelegate.Shared.InitialAmount = amount;
			    }
		    };

		    NavigateToTipCalculator.TouchUpInside += (sender, e) => AppDelegate.Shared.NavigateToTipCalc();

		    MessagingCenter.Subscribe<object, TipArgs>(TipCalc.Messages.Sender, TipCalc.Messages.Tip, 
			    (obj, args) => TipAmount.Text = args.Tip.ToString("C"));
	    }
    }
}