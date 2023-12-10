namespace Task2
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button solveButton;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.solveButton = new System.Windows.Forms.Button();
			this.SuspendLayout();

			// solveButton
			this.solveButton.Location = new System.Drawing.Point(50, 50);
			this.solveButton.Name = "solveButton";
			this.solveButton.Size = new System.Drawing.Size(150, 30);
			this.solveButton.TabIndex = 0;
			this.solveButton.Text = "Solve Inequality";
			this.solveButton.UseVisualStyleBackColor = true;
			this.solveButton.Click += new System.EventHandler(this.SolveButton_Click);

			// Form1
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.solveButton);
			this.Name = "Form1";
			this.Text = "Inequality Solver";
			this.ResumeLayout(false);
		}

		#endregion
	}
}
