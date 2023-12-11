// MainForm.Designer.cs
namespace ToyStoreApp
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.btnFindToys = new System.Windows.Forms.Button();
			this.txtMaxPrice = new System.Windows.Forms.TextBox();
			this.lblMaxPrice = new System.Windows.Forms.Label();
			this.lblAgeGroup = new System.Windows.Forms.Label();
			this.txtAgeGroup = new System.Windows.Forms.TextBox();
			this.btnFindExpensiveToys = new System.Windows.Forms.Button();
			this.btnFindToyPrices = new System.Windows.Forms.Button();
			this.txtToyType = new System.Windows.Forms.TextBox();
			this.lblToyType = new System.Windows.Forms.Label();
			this.SuspendLayout();

			// btnFindToys
			this.btnFindToys.Location = new System.Drawing.Point(12, 80);
			this.btnFindToys.Name = "btnFindToys";
			this.btnFindToys.Size = new System.Drawing.Size(150, 23);
			this.btnFindToys.Text = "Find Toys";
			this.btnFindToys.UseVisualStyleBackColor = true;
			this.btnFindToys.Click += new System.EventHandler(this.btnFindToys_Click);

			// txtMaxPrice
			this.txtMaxPrice.Location = new System.Drawing.Point(188, 16);
			this.txtMaxPrice.Name = "txtMaxPrice";
			this.txtMaxPrice.Size = new System.Drawing.Size(100, 20);

			// lblMaxPrice
			this.lblMaxPrice.AutoSize = true;
			this.lblMaxPrice.Location = new System.Drawing.Point(12, 19);
			this.lblMaxPrice.Name = "lblMaxPrice";
			this.lblMaxPrice.Size = new System.Drawing.Size(107, 13);
			this.lblMaxPrice.Text = "Max Price (UAH):";

			// lblAgeGroup
			this.lblAgeGroup.AutoSize = true;
			this.lblAgeGroup.Location = new System.Drawing.Point(12, 53);
			this.lblAgeGroup.Name = "lblAgeGroup";
			this.lblAgeGroup.Size = new System.Drawing.Size(99, 13);
			this.lblAgeGroup.Text = "Age Group (e.g., 2-5):";

			// txtAgeGroup
			this.txtAgeGroup.Location = new System.Drawing.Point(188, 50);
			this.txtAgeGroup.Name = "txtAgeGroup";
			this.txtAgeGroup.Size = new System.Drawing.Size(100, 20);

			// btnFindExpensiveToys
			this.btnFindExpensiveToys.Location = new System.Drawing.Point(12, 119);
			this.btnFindExpensiveToys.Name = "btnFindExpensiveToys";
			this.btnFindExpensiveToys.Size = new System.Drawing.Size(150, 23);
			this.btnFindExpensiveToys.Text = "Find Expensive Toys";
			this.btnFindExpensiveToys.UseVisualStyleBackColor = true;
			this.btnFindExpensiveToys.Click += new System.EventHandler(this.btnFindExpensiveToys_Click);

			// btnFindToyPrices
			this.btnFindToyPrices.Location = new System.Drawing.Point(12, 161);
			this.btnFindToyPrices.Name = "btnFindToyPrices";
			this.btnFindToyPrices.Size = new System.Drawing.Size(150, 23);
			this.btnFindToyPrices.Text = "Find Toy Prices";
			this.btnFindToyPrices.UseVisualStyleBackColor = true;
			this.btnFindToyPrices.Click += new System.EventHandler(this.btnFindToyPrices_Click);

			// lblToyType
			this.lblToyType.AutoSize = true;
			this.lblToyType.Location = new System.Drawing.Point(185, 147);
			this.lblToyType.Name = "lblToyType";
			this.lblToyType.Size = new System.Drawing.Size(57, 13);
			this.lblToyType.Text = "Toy Type:";

			// txtToyType
			this.txtToyType.Location = new System.Drawing.Point(188, 161);
			this.txtToyType.Name = "txtToyType";
			this.txtToyType.Size = new System.Drawing.Size(100, 20);


			// MainForm
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 220);
			this.Controls.Add(this.lblToyType);
			this.Controls.Add(this.txtToyType);
			this.Controls.Add(this.btnFindToyPrices);
			this.Controls.Add(this.btnFindExpensiveToys);
			this.Controls.Add(this.txtAgeGroup);
			this.Controls.Add(this.lblAgeGroup);
			this.Controls.Add(this.lblMaxPrice);
			this.Controls.Add(this.txtMaxPrice);
			this.Controls.Add(this.btnFindToys);
			this.Name = "MainForm";
			this.Text = "Toy Store App";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private System.Windows.Forms.Button btnFindToys;
		private System.Windows.Forms.TextBox txtMaxPrice;
		private System.Windows.Forms.Label lblMaxPrice;
		private System.Windows.Forms.Label lblAgeGroup;
		private System.Windows.Forms.TextBox txtAgeGroup;
		private System.Windows.Forms.Button btnFindExpensiveToys;
		private System.Windows.Forms.Button btnFindToyPrices;
		private System.Windows.Forms.TextBox txtToyType;
		private System.Windows.Forms.Label lblToyType;
	}
}
