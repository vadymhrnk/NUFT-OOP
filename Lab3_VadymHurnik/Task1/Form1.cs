using System;
using System.IO;
using System.Windows.Forms;

namespace Task1
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
			using (MyResource resource = new MyResource())
			{
				byte[] data = { 1, 2, 3, 4, 5 };
				resource.fileStream?.Write(data, 0, data.Length);
			}
		}
	}

	public class MyResource : IDisposable
	{
		private bool disposed = false;
		public FileStream fileStream;

		public MyResource()
		{
			fileStream = new FileStream("text.txt", FileMode.OpenOrCreate);
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					fileStream?.Dispose();
				}

				disposed = true;
			}
		}
	}
}
