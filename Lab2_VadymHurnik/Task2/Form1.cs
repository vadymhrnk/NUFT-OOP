namespace Task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			if (double.TryParse(xTextBox.Text, out double x) &&
			   double.TryParse(yTextBox.Text, out double y) &&
			   double.TryParse(zTextBox.Text, out double z) &&
			   x > 0)
			{
				double a = 2 * Math.Pow(x + Math.Pow(Math.Abs(y), 1.0 / 4.0), 1.0 / (-x));
				double b = Math.Pow(Math.Pow(Math.E, x - (z / Math.Sin(x))), 1.0 / 9.0);

				aLabel.Text = $"a = {a:F2}";
				bLabel.Text = $"b = {b:F2}";
			}
			else
			{
				MessageBox.Show("Invalid input. Please enter valid double values for x, y, and z.\nx can't be 0 or less.");
			}
		}
	}
}