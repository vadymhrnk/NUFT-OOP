namespace FileControlApp
{
	public partial class InputForm : Form
	{
		public string UserInput { get; private set; }

		public InputForm(string prompt)
		{
			InitializeComponent();
			PromptLabel.Text = prompt;
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			UserInput = InputTextBox.Text;
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
