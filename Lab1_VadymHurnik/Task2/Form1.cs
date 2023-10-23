namespace Task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string input = textBox1.Text;

			if (input.Length != 4 || !int.TryParse(input, out int number) || input[0].Equals('0'))
			{
				MessageBox.Show("Invalid 4-digit number.");
				return;
			}

			int digit1 = number % 10;
			number /= 10;
			int digit2 = number % 10;
			number /= 10;
			int digit3 = number % 10;
			number /= 10;
			int digit4 = number % 10;

			int product = digit1 * digit2 * digit3 * digit4;

			textBox2.Text = product.ToString();

		}
	}
}