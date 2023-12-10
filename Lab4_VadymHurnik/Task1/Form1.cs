using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			buttonCalculate.Click += CalculateButton_Click; // Add this line to wire up the button click event
		}

		private void CalculateButton_Click(object sender, EventArgs e)
		{
			if (double.TryParse(textBoxX.Text, out double x) && double.TryParse(textBoxY.Text, out double y))
			{
				double f = Math.Cos(x);
				double s;

				if (f > 0.5)
				{
					s = Math.Pow(x + y, 2) - Math.Sqrt(y);
				}
				else if (f > -0.5)
				{
					s = Math.Pow(x + y, 2) + Math.Pow(x * y, 3);
				}
				else
				{
					s = Math.Pow(x + y, 2) + Math.Log(y);
				}

				labelF.Text = $"f(x): {f:F4}";
				labelS.Text = $"s(x, y): {s:F4}";
			}
			else
			{
				MessageBox.Show("Please enter valid numeric values for x and y.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
