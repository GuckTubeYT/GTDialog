/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 19:20
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of AddTextbox.
	/// </summary>
	public partial class AddTextbox : Form
	{
		public AddTextbox()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0) {
				MessageBox.Show("Please fill the Textbox Text", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_textbox|" + textBox1.Text + "|\n";
			this.Close();
		}
	}
}
