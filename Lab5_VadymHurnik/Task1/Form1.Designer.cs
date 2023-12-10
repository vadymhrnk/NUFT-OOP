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
			this.txtLength = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtB = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtArrayElements = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtLength
			// 
			this.txtLength.Location = new System.Drawing.Point(153, 24);
			this.txtLength.Name = "txtLength";
			this.txtLength.Size = new System.Drawing.Size(100, 20);
			this.txtLength.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Array length";
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(153, 64);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(50, 20);
			this.txtA.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "a:";
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(235, 64);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(50, 20);
			this.txtB.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(209, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(20, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "b:";
			// 
			// txtArrayElements
			// 
			this.txtArrayElements.Location = new System.Drawing.Point(153, 107);
			this.txtArrayElements.Name = "txtArrayElements";
			this.txtArrayElements.Size = new System.Drawing.Size(233, 20);
			this.txtArrayElements.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(101, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Array elements (,)";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(153, 155);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 8;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 201);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtArrayElements);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtA);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLength);
			this.Name = "MainForm";
			this.Text = "Array Processing App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtA;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtB;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtArrayElements;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCalculate;
	}
}