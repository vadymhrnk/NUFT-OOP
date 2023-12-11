namespace MatrixManipulationApp
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.btnHighlight = new System.Windows.Forms.Button();
			this.btnFindMaxSumRow = new System.Windows.Forms.Button();
			this.SuspendLayout();

			// btnHighlight
			this.btnHighlight.Location = new System.Drawing.Point(50, 20);
			this.btnHighlight.Name = "btnHighlight";
			this.btnHighlight.Size = new System.Drawing.Size(120, 30);
			this.btnHighlight.Text = "Highlight Elements";
			this.btnHighlight.UseVisualStyleBackColor = true;
			this.btnHighlight.Click += new System.EventHandler(this.btnHighlight_Click);

			// btnFindMaxSumRow
			this.btnFindMaxSumRow.Location = new System.Drawing.Point(200, 20);
			this.btnFindMaxSumRow.Name = "btnFindMaxSumRow";
			this.btnFindMaxSumRow.Size = new System.Drawing.Size(150, 30);
			this.btnFindMaxSumRow.Text = "Find Max Sum Row";
			this.btnFindMaxSumRow.UseVisualStyleBackColor = true;
			this.btnFindMaxSumRow.Click += new System.EventHandler(this.btnFindMaxSumRow_Click);

			// MainForm
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 300);
			this.Controls.Add(this.btnFindMaxSumRow);
			this.Controls.Add(this.btnHighlight);
			this.Name = "MainForm";
			this.Text = "Matrix Manipulation";
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.Button btnHighlight;
		private System.Windows.Forms.Button btnFindMaxSumRow;
	}
}
