using System;
using System.Drawing;
using System.Windows.Forms;

namespace MatrixManipulationApp
{
	public partial class MainForm : Form
	{
		private TextBox[,] matrixTextBoxes;

		public MainForm()
		{
			InitializeComponent();
			InitializeMatrixTextBoxes();
		}

		private void InitializeMatrixTextBoxes()
		{
			matrixTextBoxes = new TextBox[5, 5];

			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					TextBox textBox = new TextBox
					{
						Width = 40,
						Height = 20,
						Location = new Point(50 * j + 20, 50 * i + 100),
						TextAlign = HorizontalAlignment.Center
					};

					matrixTextBoxes[i, j] = textBox;
					Controls.Add(textBox);
				}
			}
		}


		private void HighlightElements()
		{
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 5; j++)
				{
					string text = matrixTextBoxes[i, j].Text;

					if (!string.IsNullOrEmpty(text) && int.TryParse(text, out int value))
					{
						if (i <= j)
						{
							matrixTextBoxes[i, j].BackColor = Color.Yellow;
						}
						else
						{
							matrixTextBoxes[i, j].BackColor = Color.White;
						}
					}
					else
					{
						matrixTextBoxes[i, j].BackColor = Color.White;
					}
				}
			}
		}

		private void FindMaxSumRow()
		{
			int maxSum = int.MinValue;
			int maxSumRowIndex = -1;

			for (int i = 0; i < 5; i++)
			{
				int currentSum = 0;

				for (int j = i; j < 5; j++)
				{
					string text = matrixTextBoxes[i, j].Text;

					if (!string.IsNullOrEmpty(text) && int.TryParse(text, out int value))
					{
						currentSum += Math.Abs(value);
					}
					else
					{
						currentSum += 0;
					}
				}

				if (currentSum > maxSum)
				{
					maxSum = currentSum;
					maxSumRowIndex = i;
				}
			}

			MessageBox.Show($"Max Sum: {maxSum}\nRow Index: {maxSumRowIndex + 1}");
		}



		private void btnHighlight_Click(object sender, EventArgs e)
		{
			HighlightElements();
		}

		private void btnFindMaxSumRow_Click(object sender, EventArgs e)
		{
			FindMaxSumRow();
		}
	}
}
