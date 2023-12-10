using FileControlApp;

namespace hurnik_KH_2_4
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			try
			{
				// Logic for creating a file
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						using (File.Create(saveFileDialog.FileName)) { }
						MessageBox.Show("File created successfully.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error creating the file: {ex.Message}");
			}
		}

		private void MoveButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				using (SaveFileDialog saveFileDialog = new SaveFileDialog())
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						File.Move(openFileDialog.FileName, saveFileDialog.FileName);
						MessageBox.Show("File moved successfully.");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error moving the file: {ex.Message}");
			}
		}

		private void AddTextToFileButton_Click(object sender, EventArgs e)
		{
			try
			{
				string filePath = GetFilePathFromUser("Select File");

				if (!string.IsNullOrEmpty(filePath))
				{
					string content = GetUserInput("Enter text to add to the file:");

					if (!string.IsNullOrEmpty(content))
					{
						using (StreamWriter sw = new StreamWriter(filePath, true))
						{
							sw.WriteLine(content);
						}

						MessageBox.Show("Text added to the file successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("No text entered. Text not added to the file.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string GetUserInput(string prompt)
		{
			using (var form = new InputForm(prompt))
			{
				var result = form.ShowDialog();
				if (result == DialogResult.OK)
				{
					return form.UserInput;
				}
			}

			return string.Empty;
		}

		public static string GetFilePathFromUser(string title = "Select File")
		{
			using (var saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Title = title;
				saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
					return saveFileDialog.FileName;
				}
			}

			return string.Empty;
		}

		private void InfoButton_Click(object sender, EventArgs e)
		{
			try
			{
				using (OpenFileDialog openFileDialog = new OpenFileDialog())
				{
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						string filePath = openFileDialog.FileName;
						FileInfo fileInfo = new FileInfo(filePath);

						string info = $"File Name: {fileInfo.Name}\n" +
									  $"File Size: {fileInfo.Length} bytes\n" +
									  $"Creation Date: {fileInfo.CreationTime}\n" +
									  $"Last Modified Date: {fileInfo.LastWriteTime}";

						MessageBox.Show(info, "File Information");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error retrieving file information: {ex.Message}");
			}
		}

		private void HelpContentButton_Click(object sender, EventArgs e)
		{
			string instructions = "Help on how to work with the application.\n\n" +
				"1. Create File:\n   Click the 'Create File' button to create a new file. " +
				"You need to select the location and name of the file.\n\n" +
				"2. Move File:\n   Click the 'Move File' button to move an existing file. " +
				"You need to select the source file and the destination location.\n\n" +
				"3. Add Text to File:\n   Click the 'Add Text to File' button to append text to an existing file. " +
				"You need to select the file and enter the text to add.\n\n" +
				"4. File Information:\n   Click the 'File Information' button to view details about a file. " +
				"You need to select the file. Displays information such as file name, size, creation date, " +
				"and last modified date.\n\n" +
				"5. Help Content:\n   Click the 'Help Content' button to view instructions on how to use the program.\n";

			MessageBox.Show(instructions, "Help");
		}

	}
}
