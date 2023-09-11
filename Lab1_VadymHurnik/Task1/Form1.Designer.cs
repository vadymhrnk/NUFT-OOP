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
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			label2 = new Label();
			textBox2 = new TextBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(47, 30);
			label1.Name = "label1";
			label1.Size = new Size(34, 20);
			label1.TabIndex = 0;
			label1.Text = "x = ";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(107, 27);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(121, 78);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "Calculate";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(16, 137);
			label2.Name = "label2";
			label2.Size = new Size(85, 20);
			label2.TabIndex = 3;
			label2.Text = "Result(h) = ";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(107, 134);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 4;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources._1;
			pictureBox1.Location = new Point(90, 237);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(616, 124);
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(pictureBox1);
			Controls.Add(textBox2);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Lab1 VadymHurnik";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button button1;
		private Label label2;
		private TextBox textBox2;
		private PictureBox pictureBox1;
	}
}