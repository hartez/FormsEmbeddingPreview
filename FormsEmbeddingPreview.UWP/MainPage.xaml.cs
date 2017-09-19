using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TipCalc;
using Xamarin.Forms.Platform.UWP;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FormsEmbeddingPreview.UWP
{
	public sealed partial class MainPage : Page
    {
	    Xamarin.Forms.ContentPage _tipCalc;

        public MainPage()
        {
            this.InitializeComponent();
        }

	    private void TipCalcButtonClicked(object sender, RoutedEventArgs e)
	    {
		    _tipCalc = _tipCalc ?? new TipCalcPage();
		    Frame.Navigate(_tipCalc);
	    }
    }
}
