using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
	public partial class MainForm : Form
	{
		private ChildForm childForm;

		public MainForm()
		{
			InitializeComponent();
			InitializeMenu();
			InitializeInfoLabel();
		}

		private void InitializeMenu()
		{
			MenuStrip menuStrip = new MenuStrip();

			ToolStripMenuItem createFormMenuItem = new ToolStripMenuItem("Create New Form");
			createFormMenuItem.ShortcutKeys = Keys.Control | Keys.N;
			createFormMenuItem.Click += CreateFormMenuItem_Click;

			ToolStripMenuItem closeFormMenuItem = new ToolStripMenuItem("Close Main Form");
			closeFormMenuItem.ShortcutKeys = Keys.Control | Keys.W;
			closeFormMenuItem.Click += CloseFormMenuItem_Click;

			ToolStripMenuItem changeFormatMenuItem = new ToolStripMenuItem("Change Main Form Format");
			changeFormatMenuItem.ShortcutKeys = Keys.Control | Keys.F;
			changeFormatMenuItem.Click += ChangeFormatMenuItem_Click;

			menuStrip.Items.Add(createFormMenuItem);
			menuStrip.Items.Add(closeFormMenuItem);
			menuStrip.Items.Add(changeFormatMenuItem);

			this.Controls.Add(menuStrip);
		}

		private void InitializeInfoLabel()
		{
			Label infoLabel = new Label();
			infoLabel.Text = "On the child form, place components for converting units of information. If the information for conversion is entered incorrectly, the form changes color to red.";
			infoLabel.AutoSize = false;
			infoLabel.TextAlign = ContentAlignment.MiddleCenter;
			infoLabel.Dock = DockStyle.Bottom;
			infoLabel.BackColor = SystemColors.Control;
			infoLabel.Padding = new Padding(20);
			infoLabel.Height = 100;

			this.Controls.Add(infoLabel);
		}





		private void CreateFormMenuItem_Click(object sender, EventArgs e)
		{
			if (childForm == null || childForm.IsDisposed)
			{
				childForm = new ChildForm();
				childForm.Show();
			}
		}

		private void CloseFormMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ChangeFormatMenuItem_Click(object sender, EventArgs e)
		{
			// Add code to change the format of the main form
			// For example, change background color or other properties
			this.BackColor = Color.LightBlue;
		}
	}
}
