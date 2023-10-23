namespace Task2
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private Button calculateButton;
		private Label aLabel;
		private Label bLabel;
		private Label xLabel;
		private Label yLabel;
		private Label zLabel;
		private TextBox xTextBox;
		private TextBox yTextBox;
		private TextBox zTextBox;
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
			calculateButton = new Button();
			aLabel = new Label();
			bLabel = new Label();
			xLabel = new Label();
			yLabel = new Label();
			zLabel = new Label();
			xTextBox = new TextBox();
			yTextBox = new TextBox();
			zTextBox = new TextBox();
			SuspendLayout();
			// 
			// calculateButton
			// 
			calculateButton.Location = new Point(12, 100);
			calculateButton.Name = "calculateButton";
			calculateButton.Size = new Size(120, 30);
			calculateButton.TabIndex = 6;
			calculateButton.Text = "Calculate";
			calculateButton.UseVisualStyleBackColor = true;
			calculateButton.Click += calculateButton_Click;
			// 
			// aLabel
			// 
			aLabel.Location = new Point(150, 12);
			aLabel.Name = "aLabel";
			aLabel.Size = new Size(300, 20);
			aLabel.TabIndex = 7;
			aLabel.Text = "a =";
			// 
			// bLabel
			// 
			bLabel.Location = new Point(150, 40);
			bLabel.Name = "bLabel";
			bLabel.Size = new Size(300, 20);
			bLabel.TabIndex = 8;
			bLabel.Text = "b =";
			// 
			// xLabel
			// 
			xLabel.Location = new Point(12, 12);
			xLabel.Name = "xLabel";
			xLabel.Size = new Size(25, 20);
			xLabel.TabIndex = 0;
			xLabel.Text = "x=";
			// 
			// yLabel
			// 
			yLabel.Location = new Point(12, 40);
			yLabel.Name = "yLabel";
			yLabel.Size = new Size(25, 20);
			yLabel.TabIndex = 2;
			yLabel.Text = "y=";
			// 
			// zLabel
			// 
			zLabel.Location = new Point(12, 68);
			zLabel.Name = "zLabel";
			zLabel.Size = new Size(25, 20);
			zLabel.TabIndex = 4;
			zLabel.Text = "z=";
			// 
			// xTextBox
			// 
			xTextBox.Location = new Point(40, 12);
			xTextBox.Name = "xTextBox";
			xTextBox.Size = new Size(100, 23);
			xTextBox.TabIndex = 1;
			// 
			// yTextBox
			// 
			yTextBox.Location = new Point(40, 40);
			yTextBox.Name = "yTextBox";
			yTextBox.Size = new Size(100, 23);
			yTextBox.TabIndex = 3;
			// 
			// zTextBox
			// 
			zTextBox.Location = new Point(40, 68);
			zTextBox.Name = "zTextBox";
			zTextBox.Size = new Size(100, 23);
			zTextBox.TabIndex = 5;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(350, 180);
			Controls.Add(xLabel);
			Controls.Add(xTextBox);
			Controls.Add(yLabel);
			Controls.Add(yTextBox);
			Controls.Add(zLabel);
			Controls.Add(zTextBox);
			Controls.Add(calculateButton);
			Controls.Add(aLabel);
			Controls.Add(bLabel);
			Name = "Form1";
			Text = "Math Calculation";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
	}
}