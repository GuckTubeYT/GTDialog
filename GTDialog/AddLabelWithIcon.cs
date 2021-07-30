/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 19/07/2021
 * Time: 20:18
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of AddLabelWithIcon.
	/// </summary>
	public partial class AddLabelWithIcon : Form
	{
		public AddLabelWithIcon()
		{
			InitializeComponent();
			textBox2.MaxLength = 5;
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (comboBox1.Text == "")
			{
				MessageBox.Show("Please fill Icon Size ComboBox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (comboBox1.Text != "small" && comboBox1.Text != "big")
			{
				MessageBox.Show("Please Set the comboBox beetween samll or big text", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("Please fill Label Text Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox2.TextLength == 0)
			{
				MessageBox.Show("Please fill Item ID Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_label_with_icon|" + comboBox1.Text + "|" + textBox1.Text + "|left|" + textBox2.Text + "|\n";
			this.Close();
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
