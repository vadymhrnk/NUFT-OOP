using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleColorChangeApp
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			ChangeFormColor(Color.Red);
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			ChangeFormColor(Color.Green);
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			ChangeFormColor(Color.Blue);
		}

		private void Button4_Click(object sender, EventArgs e)
		{
			ChangeFormColor(Color.Yellow);
		}

		private void ChangeFormColor(Color color)
		{
			this.BackColor = color;
		}
	}
}
