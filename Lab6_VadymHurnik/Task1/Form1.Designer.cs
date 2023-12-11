namespace MatrixTransformationApp
{
	partial class MainForm
	{
		private System.Windows.Forms.Button btnGenerateMatrix;
		private System.Windows.Forms.Button btnTransformMatrix;
		private System.Windows.Forms.TextBox txtMatrixSize;
		private System.Windows.Forms.Label lblMatrixSize;
		private System.Windows.Forms.TableLayoutPanel matrixTableLayoutPanel;

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGenerateMatrix = new System.Windows.Forms.Button();
			this.btnTransformMatrix = new System.Windows.Forms.Button();
			this.txtMatrixSize = new System.Windows.Forms.TextBox();
			this.lblMatrixSize = new System.Windows.Forms.Label();
			this.matrixTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();

			this.SuspendLayout();

			// 
			// btnGenerateMatrix
			// 
			this.btnGenerateMatrix.Location = new System.Drawing.Point(97, 30);
			this.btnGenerateMatrix.Name = "btnGenerateMatrix";
			this.btnGenerateMatrix.Size = new System.Drawing.Size(292, 40);
			this.btnGenerateMatrix.TabIndex = 0;
			this.btnGenerateMatrix.Text = "Generate Matrix";
			this.btnGenerateMatrix.UseVisualStyleBackColor = true;
			this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
			// 
			// btnTransformMatrix
			// 
			this.btnTransformMatrix.Location = new System.Drawing.Point(405, 30);
			this.btnTransformMatrix.Name = "btnTransformMatrix";
			this.btnTransformMatrix.Size = new System.Drawing.Size(292, 40);
			this.btnTransformMatrix.TabIndex = 2;
			this.btnTransformMatrix.Text = "Transform Matrix";
			this.btnTransformMatrix.UseVisualStyleBackColor = true;
			this.btnTransformMatrix.Click += new System.EventHandler(this.btnTransformMatrix_Click);
			// 
			// txtMatrixSize
			// 
			this.txtMatrixSize.Location = new System.Drawing.Point(278, 85);
			this.txtMatrixSize.Name = "txtMatrixSize";
			this.txtMatrixSize.Size = new System.Drawing.Size(100, 22);
			this.txtMatrixSize.TabIndex = 3;
			// 
			// lblMatrixSize
			// 
			this.lblMatrixSize.AutoSize = true;
			this.lblMatrixSize.Location = new System.Drawing.Point(198, 88);
			this.lblMatrixSize.Name = "lblMatrixSize";
			this.lblMatrixSize.Size = new System.Drawing.Size(73, 17);
			this.lblMatrixSize.TabIndex = 4;
			this.lblMatrixSize.Text = "Matrix Size:";

			// 
			// matrixTableLayoutPanel
			// 
			this.matrixTableLayoutPanel.AutoSize = true;
			this.matrixTableLayoutPanel.Location = new System.Drawing.Point(12, 130);
			this.matrixTableLayoutPanel.Name = "matrixTableLayoutPanel";
			this.matrixTableLayoutPanel.TabIndex = 5;

			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 500);
			this.Controls.Add(this.lblMatrixSize);
			this.Controls.Add(this.txtMatrixSize);
			this.Controls.Add(this.btnTransformMatrix);
			this.Controls.Add(this.btnGenerateMatrix);
			this.Controls.Add(this.matrixTableLayoutPanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Matrix Transformation App";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
	}
}
