/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 19:33
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of UrlButton.
	/// </summary>
	public partial class UrlButton : Form
	{
		public UrlButton()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0) {
				MessageBox.Show("Please fill the Url Button Text Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox1.TextLength == 0) {
				MessageBox.Show("Please fill the Url Link Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox1.TextLength == 0) {
				MessageBox.Show("Please fill the Messagebox Text Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_url_button|" + textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|\n";
			this.Close();
		}
	}
}
