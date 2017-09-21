namespace TipCalc
{
	public static class Messages
	{
		public static object Sender = new object();

		public const string InitialAmount = "InitialAmount";
		public const string Tip = "Tip";
	}

	public class InitialAmountArgs
	{
		public InitialAmountArgs(double initialAmount)
		{
			InitialAmount = initialAmount;
		}

		public double InitialAmount { get; }
	}

	public class TipArgs
	{
		public TipArgs(double tip)
		{
			Tip = tip;
		}

		public double Tip { get; }
	}
}