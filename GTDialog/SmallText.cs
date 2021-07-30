/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 16:30
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of SmallText.
	/// </summary>
	public partial class SmallText : Form
	{
		public SmallText()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("Please fill the Text Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (checkBox2.Checked){
				if (textBox2.TextLength == 0) {
					MessageBox.Show("Please fill the Size Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				Variable.resultDialog = "add_smalltext_forced_alpha|" + textBox1.Text + "|" + textBox2.Text + "|left|\n";
				this.Close();
				return;
			}
			if (checkBox1.Checked)
			{
				Variable.resultDialog = "add_smalltext_forced|" + textBox1.Text + "|left|\n";
				this.Close();
				return;
			}
			
			Variable.resultDialog = "add_smalltext|" + textBox1.Text + "|left|\n";
			this.Close();
		}
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked) {
				checkBox2.Enabled = true;
			}
			else {
				checkBox2.Enabled = false;
				checkBox2.Checked = false;
			}
		}
		void SmallTextLoad(object sender, EventArgs e)
		{
			checkBox2.Enabled = false;
			textBox2.Enabled = false;
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox2.Checked) {
				textBox2.Enabled = true;
			}
			else {
				textBox2.Enabled = false;
				textBox2.Text = "";
			}
		}
	}
}
