using System.Security.Policy;

namespace Task1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string x = textBox1.Text;
			float number, h , a, b, c;
			if (!float.TryParse(x, out number))
			{
				MessageBox.Show("Wrong input.");
				return;
			}
			a = (float)(Math.Pow(Math.Sin(number), 3) + Math.Pow(number, 4));
			b = (float)(Math.Sqrt(number) - Math.Log(number));
			c = (float)(4 * number - 5 * Math.Pow(number, 3));
			h = (float)(Math.Pow(a, 3) + Math.Pow(b, 2) - 8 * c);
			textBox2.Text = h.ToString();

		}
	}
}