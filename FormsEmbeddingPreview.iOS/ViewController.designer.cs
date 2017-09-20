// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace FormsEmbeddingPreview.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel InitAmountLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField InitialAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MainText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NavigateToTipCalculator { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipAmountLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (InitAmountLabel != null) {
                InitAmountLabel.Dispose ();
                InitAmountLabel = null;
            }

            if (InitialAmount != null) {
                InitialAmount.Dispose ();
                InitialAmount = null;
            }

            if (MainText != null) {
                MainText.Dispose ();
                MainText = null;
            }

            if (NavigateToTipCalculator != null) {
                NavigateToTipCalculator.Dispose ();
                NavigateToTipCalculator = null;
            }

            if (TipAmount != null) {
                TipAmount.Dispose ();
                TipAmount = null;
            }

            if (TipAmountLabel != null) {
                TipAmountLabel.Dispose ();
                TipAmountLabel = null;
            }
        }
    }
}