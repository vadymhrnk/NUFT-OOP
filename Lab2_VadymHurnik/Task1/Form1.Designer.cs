namespace Task1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			whiteCheckerXTextBox = new TextBox();
			whiteCheckerYTextBox = new TextBox();
			blackCheckerXTextBox = new TextBox();
			blackCheckerYTextBox = new TextBox();
			checkButton = new Button();
			resultLabel = new Label();
			whiteCheckerXLabel = new Label();
			whiteCheckerYLabel = new Label();
			blackCheckerXLabel = new Label();
			blackCheckerYLabel = new Label();
			SuspendLayout();
			// 
			// whiteCheckerXTextBox
			// 
			whiteCheckerXTextBox.Location = new Point(118, 17);
			whiteCheckerXTextBox.Margin = new Padding(4, 3, 4, 3);
			whiteCheckerXTextBox.Name = "whiteCheckerXTextBox";
			whiteCheckerXTextBox.Size = new Size(116, 23);
			whiteCheckerXTextBox.TabIndex = 0;
			// 
			// whiteCheckerYTextBox
			// 
			whiteCheckerYTextBox.Location = new Point(118, 46);
			whiteCheckerYTextBox.Margin = new Padding(4, 3, 4, 3);
			whiteCheckerYTextBox.Name = "whiteCheckerYTextBox";
			whiteCheckerYTextBox.Size = new Size(116, 23);
			whiteCheckerYTextBox.TabIndex = 1;
			// 
			// blackCheckerXTextBox
			// 
			blackCheckerXTextBox.Location = new Point(118, 75);
			blackCheckerXTextBox.Margin = new Padding(4, 3, 4, 3);
			blackCheckerXTextBox.Name = "blackCheckerXTextBox";
			blackCheckerXTextBox.Size = new Size(116, 23);
			blackCheckerXTextBox.TabIndex = 2;
			// 
			// blackCheckerYTextBox
			// 
			blackCheckerYTextBox.Location = new Point(118, 107);
			blackCheckerYTextBox.Margin = new Padding(4, 3, 4, 3);
			blackCheckerYTextBox.Name = "blackCheckerYTextBox";
			blackCheckerYTextBox.Size = new Size(116, 23);
			blackCheckerYTextBox.TabIndex = 3;
			// 
			// checkButton
			// 
			checkButton.Location = new Point(282, 66);
			checkButton.Margin = new Padding(4, 3, 4, 3);
			checkButton.Name = "checkButton";
			checkButton.Size = new Size(88, 27);
			checkButton.TabIndex = 4;
			checkButton.Text = "Check";
			checkButton.UseVisualStyleBackColor = true;
			checkButton.Click += checkButton_Click;
			// 
			// resultLabel
			// 
			resultLabel.AutoSize = true;
			resultLabel.Location = new Point(14, 164);
			resultLabel.Margin = new Padding(4, 0, 4, 0);
			resultLabel.Name = "resultLabel";
			resultLabel.Size = new Size(0, 15);
			resultLabel.TabIndex = 5;
			// 
			// whiteCheckerXLabel
			// 
			whiteCheckerXLabel.AutoSize = true;
			whiteCheckerXLabel.Location = new Point(14, 20);
			whiteCheckerXLabel.Name = "whiteCheckerXLabel";
			whiteCheckerXLabel.Size = new Size(97, 15);
			whiteCheckerXLabel.TabIndex = 0;
			whiteCheckerXLabel.Text = "White Checker X:";
			// 
			// whiteCheckerYLabel
			// 
			whiteCheckerYLabel.AutoSize = true;
			whiteCheckerYLabel.Location = new Point(14, 49);
			whiteCheckerYLabel.Name = "whiteCheckerYLabel";
			whiteCheckerYLabel.Size = new Size(97, 15);
			whiteCheckerYLabel.TabIndex = 1;
			whiteCheckerYLabel.Text = "White Checker Y:";
			// 
			// blackCheckerXLabel
			// 
			blackCheckerXLabel.AutoSize = true;
			blackCheckerXLabel.Location = new Point(14, 78);
			blackCheckerXLabel.Name = "blackCheckerXLabel";
			blackCheckerXLabel.Size = new Size(94, 15);
			blackCheckerXLabel.TabIndex = 2;
			blackCheckerXLabel.Text = "Black Checker X:";
			// 
			// blackCheckerYLabel
			// 
			blackCheckerYLabel.AutoSize = true;
			blackCheckerYLabel.Location = new Point(14, 110);
			blackCheckerYLabel.Name = "blackCheckerYLabel";
			blackCheckerYLabel.Size = new Size(94, 15);
			blackCheckerYLabel.TabIndex = 3;
			blackCheckerYLabel.Text = "Black Checker Y:";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(438, 235);
			Controls.Add(whiteCheckerXLabel);
			Controls.Add(whiteCheckerYLabel);
			Controls.Add(blackCheckerXLabel);
			Controls.Add(blackCheckerYLabel);
			Controls.Add(resultLabel);
			Controls.Add(checkButton);
			Controls.Add(blackCheckerYTextBox);
			Controls.Add(blackCheckerXTextBox);
			Controls.Add(whiteCheckerYTextBox);
			Controls.Add(whiteCheckerXTextBox);
			Margin = new Padding(4, 3, 4, 3);
			Name = "Form1";
			Text = "Checkers Checker";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox whiteCheckerXTextBox;
		private TextBox whiteCheckerYTextBox;
		private TextBox blackCheckerXTextBox;
		private TextBox blackCheckerYTextBox;
		private Button checkButton;
		private Label resultLabel;
		private Label whiteCheckerXLabel;
		private Label whiteCheckerYLabel;
		private Label blackCheckerXLabel;
		private Label blackCheckerYLabel;
	}
}