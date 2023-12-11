using System;
using System.Windows.Forms;

namespace MatrixTransformationApp
{
	public partial class MainForm : Form
	{
		private int[,] matrix;

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnGenerateMatrix_Click(object sender, EventArgs e)
		{
			if (int.TryParse(txtMatrixSize.Text, out int size) && size % 2 == 0)
			{
				matrix = GenerateMatrix(size);
				DisplayMatrix();
				MessageBox.Show("Matrix generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Please enter a valid even number for the matrix size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTransformMatrix_Click(object sender, EventArgs e)
		{
			if (matrix != null)
			{
				matrix = TransformMatrix(matrix);
				DisplayMatrix();
			}
			else
			{
				MessageBox.Show("Please generate a matrix first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DisplayMatrix()
		{
			matrixTableLayoutPanel.Controls.Clear();

			int size = matrix.GetLength(0);

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					TextBox textBox = new TextBox
					{
						Text = matrix[i, j].ToString(),
						Width = 40,
						Height = 20,
						TextAlign = HorizontalAlignment.Center,
						ReadOnly = true
					};

					matrixTableLayoutPanel.Controls.Add(textBox, j, i);
				}
			}
		}

		private int[,] GenerateMatrix(int size)
		{
			int[,] result = new int[size, size];
			Random random = new Random();

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					result[i, j] = random.Next(1, 100);
				}
			}

			return result;
		}

		private int[,] TransformMatrix(int[,] originalMatrix)
		{
			int size = originalMatrix.GetLength(0);
			int[,] transformedMatrix = new int[size, size];

			for (int i = 0; i < size; i += 2)
			{
				for (int j = 0; j < size; j++)
				{
					transformedMatrix[i, j] = originalMatrix[(i + 1) % size, j];
					transformedMatrix[i + 1, j] = originalMatrix[i, j];
				}
			}

			return transformedMatrix;
		}
	}
}
