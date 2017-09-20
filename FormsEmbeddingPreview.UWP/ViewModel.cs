using System.ComponentModel;
using System.Runtime.CompilerServices;
using TipCalc;
using Xamarin.Forms;

namespace FormsEmbeddingPreview.UWP
{
	internal class ViewModel : INotifyPropertyChanged
	{
		private static ViewModel _instance1;
		private double _initialAmount;
		private double _tip;
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		internal static ViewModel Instance => _instance1 ?? (_instance1 = new ViewModel());

		public ViewModel()
		{
			InitialAmount = 0;
			MessagingCenter.Subscribe<object, TipArgs>(Messages.Sender, Messages.Tip, 
				(obj, args) => Tip = args.Tip);
		}

		public double InitialAmount
		{
			get { return _initialAmount; }
			set
			{
				_initialAmount = value;
				OnPropertyChanged();
			}
		}

		public double Tip
		{
			get { return _tip; }
			set
			{
				_tip = value;
				OnPropertyChanged();
			}
		}

		public string TipCurrency => _tip.ToString("C");
	}
}