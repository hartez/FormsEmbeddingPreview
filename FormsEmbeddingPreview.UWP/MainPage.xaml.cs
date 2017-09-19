using Windows.UI.Xaml;
using TipCalc;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Application = Windows.UI.Xaml.Application;
using Page = Windows.UI.Xaml.Controls.Page;

namespace FormsEmbeddingPreview.UWP
{
	public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
	        DataContext = ViewModel.Instance;
        }

	    private void TipCalcButtonClicked(object sender, RoutedEventArgs e)
	    {
			var tipCalc = ((App)Application.Current).TipCalc.Value;

		    MessagingCenter.Send(Messages.Sender, Messages.InitialAmount, 
				new InitialAmountArgs(ViewModel.Instance.InitialAmount));

		    Frame.Navigate(tipCalc);
	    }
    }
}
