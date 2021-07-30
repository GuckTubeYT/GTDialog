/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 19/07/2021
 * Time: 19:01
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of CheckboxButton.
	/// </summary>
	public partial class CheckboxButton : Form
	{
		public CheckboxButton()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0) {
				MessageBox.Show("Please fill the Checkbox Name Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox2.TextLength == 0) {
				MessageBox.Show("Please fill the Checkbox Text Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (checkBox1.Checked) {
				Variable.resultDialog = "add_checkbox|" + textBox1.Text + "|" + textBox2.Text + "|1|\n";
				this.Close();
				return;
			}
			else
			{
				Variable.resultDialog = "add_checkbox|" + textBox1.Text + "|" + textBox2.Text + "|0|\n";
				this.Close();
				return;
			}
			
		}
	}
}
