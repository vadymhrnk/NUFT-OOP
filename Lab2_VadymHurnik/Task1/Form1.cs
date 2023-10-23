namespace Task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private void checkButton_Click(object sender, EventArgs e)
		{
			if (int.TryParse(whiteCheckerXTextBox.Text, out int whiteCheckerX) &&
				int.TryParse(whiteCheckerYTextBox.Text, out int whiteCheckerY) &&
				int.TryParse(blackCheckerXTextBox.Text, out int blackCheckerX) &&
				int.TryParse(blackCheckerYTextBox.Text, out int blackCheckerY))
			{
				bool isUnderAttack = IsUnderAttack(whiteCheckerX, whiteCheckerY, blackCheckerX, blackCheckerY);

				if (isUnderAttack)
				{
					resultLabel.Text = "The black checker is under threat from the white checker.";
				}
				else
				{
					resultLabel.Text = "The black checker is not under threat from the white checker.";
				}
			}
			else
			{
				resultLabel.Text = "Invalid coordinate format.";
			}
		}

		private bool IsUnderAttack(int whiteCheckerX, int whiteCheckerY, int blackCheckerX, int blackCheckerY)
		{
			// Check if the black checker is one square diagonally forward from the white checker.
			if (Math.Abs(whiteCheckerX - blackCheckerX) == 1 && whiteCheckerY - blackCheckerY == 1)
			{
				return true;
			}

			return false;
		}
	}
}