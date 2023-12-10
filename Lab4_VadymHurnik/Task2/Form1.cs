using System;
using System.Windows.Forms;

namespace Task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void SolveButton_Click(object sender, EventArgs e)
		{
			int min_X = 0;
			int min_Y = 0;
			bool found = false;

			for (int x = -50; x <= 50; x++)
			{
				for (int y = -50; y <= 50; y++)
				{
					if (x * x + y * y == 1201)
					{
						if (!found || (x < min_X) || (x == min_X && y < min_Y))
						{
							min_X = x;
							min_Y = y;
							found = true;
						}
					}
				}
			}

			if (found)
			{
				MessageBox.Show($"Lowest combination: x = {min_X}, y = {min_Y}", "Solution Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("No solutions found for the given inequality.", "No Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
