using System;
using System.Windows.Forms;

namespace Task1
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

			if (!float.TryParse(input, out float number))
			{
				MessageBox.Show("Invalid input. Please enter a valid number.");
				return;
			}

			if (number == 0)
			{
				MessageBox.Show("Invalid input. Please enter a non-zero number.");
				return;
			}

			if (number < 0)
			{
				MessageBox.Show("Invalid input. Please enter a non-negative number.");
				return;
			}

			double a = Math.Pow(Math.Sin(number), 3) + Math.Pow(number, 4);
			double b = Math.Sqrt(number) - Math.Log(number);
			double c = 4 * number - 5 * Math.Pow(number, 3);
			double h = Math.Pow(a, 3) + Math.Pow(b, 2) - 8 * c;

			textBox2.Text = h.ToString("F2");
		}
	}
}
