using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
	public partial class ChildForm : Form
	{
		private TextBox inputTextBox;
		private Label resultLabel;

		public ChildForm()
		{
			InitializeComponent();
			InitializeComponents();
		}

		private void InitializeComponents()
		{
			Text = "Child Form";
			Size = new Size(300, 200);

			inputTextBox = new TextBox();
			inputTextBox.Location = new Point(20, 20);
			inputTextBox.Size = new Size(200, 25);

			Button convertButton = new Button();
			convertButton.Text = "Convert";
			convertButton.Location = new Point(20, 60);
			convertButton.Click += ConvertButton_Click;

			resultLabel = new Label();
			resultLabel.Location = new Point(20, 100);
			resultLabel.Size = new Size(200, 50);

			this.Controls.Add(inputTextBox);
			this.Controls.Add(convertButton);
			this.Controls.Add(resultLabel);
		}

		private void ConvertButton_Click(object sender, EventArgs e)
		{
			if (double.TryParse(inputTextBox.Text, out double inputValue))
			{
				double convertedValue = inputValue * 2;

				resultLabel.Text = $"Converted Value: {convertedValue}";
				resultLabel.ForeColor = Color.Black;
				this.BackColor = SystemColors.Control; 
			}
			else
			{
				resultLabel.Text = "Invalid Input";
				resultLabel.ForeColor = Color.Red;
				this.BackColor = Color.FromArgb(255, 200, 200);
			}
		}
	}
}
