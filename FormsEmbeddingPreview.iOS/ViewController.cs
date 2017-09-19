using Foundation;
using System;
using UIKit;

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
		    NavigateToTipCalculator.TouchUpInside += (sender, e) => AppDelegate.Shared.NavigateToTipCalc();
	    }
    }
}