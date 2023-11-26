using System;
using System.Windows.Forms;

namespace Task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			InitializeComponents();
		}

		private void InitializeComponents()
		{
			Shape shape = new Shape();
			shape.Display();


			Circle circle = new Circle();
			circle.Display();
		}
	}

	class Shape
	{
		public virtual void Display()
		{
			MessageBox.Show("Shape");
		}
	}

	class Circle : Shape
	{
		public override void Display()
		{
			MessageBox.Show("Circle");
		}
	}
}
