using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ToyStoreApp
{
	public partial class MainForm : Form
	{
		private List<Toy> toys;

		public MainForm()
		{
			InitializeComponent();
			LoadToyData();
		}

		private void LoadToyData()
		{
			toys = new List<Toy>();

			try
			{
				// Assuming toy data is stored in a text file named "ToyData.txt"
				string[] lines = File.ReadAllLines("../../../ToyData.txt");

				foreach (string line in lines)
				{
					string[] fields = line.Split(',');
					if (fields.Length == 3)
					{
						string name = fields[0].Trim();
						string priceString = fields[1].Trim().Replace('.', ',');

						// Validate and handle empty price input
						if (string.IsNullOrEmpty(priceString))
						{
							MessageBox.Show("Invalid price in toy data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							continue;
						}

						double price = double.Parse(priceString);
						string ageRange = fields[2].Trim();

						Toy toy = new Toy(name, price, ageRange);
						toys.Add(toy);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading toy data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnFindToys_Click(object sender, EventArgs e)
		{
			// Validate and handle empty max price or age group input
			if (string.IsNullOrEmpty(txtMaxPrice.Text) || string.IsNullOrEmpty(txtAgeGroup.Text))
			{
				MessageBox.Show("Please enter valid values for Max Price and Age Group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// 1) Find toys based on price and age range
			double maxPrice = Convert.ToDouble(txtMaxPrice.Text);
			string ageGroup = txtAgeGroup.Text.Trim();

			var filteredToys = toys.Where(t => t.Price <= maxPrice && t.IsAgeAppropriate(ageGroup));

			// Display results
			MessageBox.Show($"Toys within the specified price range for {ageGroup}:\n\n{string.Join("\n", filteredToys)}", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnFindExpensiveToys_Click(object sender, EventArgs e)
		{
			// 2) Find names of the most expensive toys (within 1 gryvnia difference)
			var mostExpensiveToys = toys.GroupBy(t => t.Price)
										.OrderByDescending(group => group.Key)
										.FirstOrDefault();

			// Display results
			MessageBox.Show($"Names of the most expensive toys:\n\n{string.Join("\n", mostExpensiveToys)}", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnFindToyPrices_Click(object sender, EventArgs e)
		{
			// Validate and handle empty toy type input
			if (string.IsNullOrEmpty(txtToyType.Text))
			{
				MessageBox.Show("Please enter a valid Toy Type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// 3) Find prices of toys of a specific type
			string toyType = txtToyType.Text.Trim();

			var toyPrices = toys.Where(t => t.Name.Equals(toyType, StringComparison.OrdinalIgnoreCase))
								.Select(t => t.Price);

			// Display results
			MessageBox.Show($"Prices of {toyType}:\n\n{string.Join("\n", toyPrices)}", "Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}

	public class Toy
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public string AgeRange { get; set; }

		public Toy(string name, double price, string ageRange)
		{
			Name = name;
			Price = price;
			AgeRange = ageRange;
		}

		public override string ToString()
		{
			return $"{Name} - {Price} UAH - Age Range: {AgeRange}";
		}

		public bool IsAgeAppropriate(string ageGroup)
		{
			string[] ageBounds = ageGroup.Split('-');
			if (ageBounds.Length == 2)
			{
				int minAge = int.Parse(ageBounds[0]);
				int maxAge = int.Parse(ageBounds[1]);

				int toyMinAge = int.Parse(AgeRange.Split('-')[0]);
				int toyMaxAge = int.Parse(AgeRange.Split('-')[1]);

				return minAge <= toyMinAge && maxAge >= toyMaxAge;
			}
			return false;
		}
	}
}
