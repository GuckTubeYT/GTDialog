/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 19:57
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of RedirectWorldButton.
	/// </summary>
	public partial class RedirectWorldButton : Form
	{
		public RedirectWorldButton()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox2.TextLength == 0)
			{
				MessageBox.Show("Please fill the World Name Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_url_button||" + textBox1.Text + "|NOFLAGS|OPENWORLD|" + textBox2.Text + "|\n";
			this.Close();
		}
	}
}
