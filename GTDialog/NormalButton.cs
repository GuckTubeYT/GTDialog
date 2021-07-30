/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 11/07/2021
 * Time: 17:42
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of NormalButton.
	/// </summary>
	public partial class NormalButton : Form
	{
		public NormalButton()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("Please fill the Name button", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox2.TextLength == 0)
			{
				MessageBox.Show("Please fill the Text button", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_button|" + textBox1.Text + "|" + textBox2.Text + "|\n";
			this.Close();
		}
	}
}
