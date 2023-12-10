namespace hurnik_KH_2_4
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
			this.createButton = new System.Windows.Forms.Button();
			this.moveButton = new System.Windows.Forms.Button();
			this.infoButton = new System.Windows.Forms.Button();
			this.helpContentButton = new System.Windows.Forms.Button();
			this.addTextToFileButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// createButton
			// 
			this.createButton.Location = new System.Drawing.Point(12, 12);
			this.createButton.Name = "createButton";
			this.createButton.Size = new System.Drawing.Size(120, 23);
			this.createButton.TabIndex = 0;
			this.createButton.Text = "Create File";
			this.createButton.UseVisualStyleBackColor = true;
			this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// moveButton
			// 
			this.moveButton.Location = new System.Drawing.Point(12, 41);
			this.moveButton.Name = "moveButton";
			this.moveButton.Size = new System.Drawing.Size(120, 23);
			this.moveButton.TabIndex = 1;
			this.moveButton.Text = "Move File";
			this.moveButton.UseVisualStyleBackColor = true;
			this.moveButton.Click += new System.EventHandler(this.MoveButton_Click);
			// 
			// infoButton
			// 
			this.infoButton.Location = new System.Drawing.Point(12, 70);
			this.infoButton.Name = "infoButton";
			this.infoButton.Size = new System.Drawing.Size(120, 23);
			this.infoButton.TabIndex = 2;
			this.infoButton.Text = "File Information";
			this.infoButton.UseVisualStyleBackColor = true;
			this.infoButton.Click += new System.EventHandler(this.InfoButton_Click);
			// 
			// helpContentButton
			// 
			this.helpContentButton.Location = new System.Drawing.Point(12, 99);
			this.helpContentButton.Name = "helpContentButton";
			this.helpContentButton.Size = new System.Drawing.Size(120, 23);
			this.helpContentButton.TabIndex = 3;
			this.helpContentButton.Text = "Help";
			this.helpContentButton.UseVisualStyleBackColor = true;
			this.helpContentButton.Click += new System.EventHandler(this.HelpContentButton_Click);
			// 
			// addTextToFileButton
			// 
			this.addTextToFileButton.Location = new System.Drawing.Point(12, 128);
			this.addTextToFileButton.Name = "addTextToFileButton";
			this.addTextToFileButton.Size = new System.Drawing.Size(120, 23);
			this.addTextToFileButton.TabIndex = 4;
			this.addTextToFileButton.Text = "Add Text to File";
			this.addTextToFileButton.UseVisualStyleBackColor = true;
			this.addTextToFileButton.Click += new System.EventHandler(this.AddTextToFileButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.addTextToFileButton);
			this.Controls.Add(this.helpContentButton);
			this.Controls.Add(this.infoButton);
			this.Controls.Add(this.moveButton);
			this.Controls.Add(this.createButton);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button createButton;
		private System.Windows.Forms.Button moveButton;
		private System.Windows.Forms.Button infoButton;
		private System.Windows.Forms.Button helpContentButton;
		private System.Windows.Forms.Button addTextToFileButton;
	}
}
