// Form1.Designer.cs

namespace Task1
{
	partial class Form1
	{
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.TextBox textBoxX;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.TextBox textBoxY;
		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Label labelF;
		private System.Windows.Forms.Label labelS;

		private void InitializeComponent()
		{
			this.labelX = new System.Windows.Forms.Label();
			this.textBoxX = new System.Windows.Forms.TextBox();
			this.labelY = new System.Windows.Forms.Label();
			this.textBoxY = new System.Windows.Forms.TextBox();
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.labelF = new System.Windows.Forms.Label();
			this.labelS = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// labelX
			this.labelX.AutoSize = true;
			this.labelX.Location = new System.Drawing.Point(20, 20);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(20, 20);
			this.labelX.TabIndex = 0;
			this.labelX.Text = "X:";

			// textBoxX
			this.textBoxX.Location = new System.Drawing.Point(45, 20);
			this.textBoxX.Name = "textBoxX";
			this.textBoxX.Size = new System.Drawing.Size(100, 20);
			this.textBoxX.TabIndex = 1;

			// labelY
			this.labelY.AutoSize = true;
			this.labelY.Location = new System.Drawing.Point(170, 20);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(20, 20);
			this.labelY.TabIndex = 2;
			this.labelY.Text = "Y:";

			// textBoxY
			this.textBoxY.Location = new System.Drawing.Point(195, 20);
			this.textBoxY.Name = "textBoxY";
			this.textBoxY.Size = new System.Drawing.Size(100, 20);
			this.textBoxY.TabIndex = 3;

			// buttonCalculate
			this.buttonCalculate.Location = new System.Drawing.Point(20, 70);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(275, 30);
			this.buttonCalculate.TabIndex = 4;
			this.buttonCalculate.Text = "Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;

			// labelF
			this.labelF.AutoSize = true;
			this.labelF.Location = new System.Drawing.Point(20, 120);
			this.labelF.Name = "labelF";
			this.labelF.Size = new System.Drawing.Size(40, 20);
			this.labelF.TabIndex = 5;
			this.labelF.Text = "f(x):";

			// labelS
			this.labelS.AutoSize = true;
			this.labelS.Location = new System.Drawing.Point(20, 170);
			this.labelS.Name = "labelS";
			this.labelS.Size = new System.Drawing.Size(55, 20);
			this.labelS.TabIndex = 6;
			this.labelS.Text = "s(x, y):";

			// Form1
			this.ClientSize = new System.Drawing.Size(700, 400);
			this.Controls.Add(this.labelX);
			this.Controls.Add(this.textBoxX);
			this.Controls.Add(this.labelY);
			this.Controls.Add(this.textBoxY);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.labelF);
			this.Controls.Add(this.labelS);
			this.Name = "Form1";
			this.Text = "Function Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
