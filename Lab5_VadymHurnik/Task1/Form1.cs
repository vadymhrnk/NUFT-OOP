namespace Task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(txtLength.Text);

			int a = Convert.ToInt32(txtA.Text);
			int b = Convert.ToInt32(txtB.Text);

			int[] array = new int[n];
			for (int i = 0; i < n; i++)
			{
				array[i] = Convert.ToInt32(txtArrayElements.Text.Split(',')[i]);
			}

			int countInInterval = 0;
			int sumOutsideInterval = 0;

			foreach (int num in array)
			{
				if (num >= a && num <= b)
				{
					countInInterval++;
				}
				else
				{
					sumOutsideInterval += num;
				}
			}

			MessageBox.Show($"Count of number in set [{a}, {b}]: {countInInterval}\nSum of other numbers: {sumOutsideInterval}");
		}
	}
}