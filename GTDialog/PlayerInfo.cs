/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 14:31
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of PlayerInfo.
	/// </summary>
	public partial class PlayerInfo : Form
	{
		public PlayerInfo()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("Please fill the Name Player Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox2.TextLength == 0)
			{
				MessageBox.Show("Please fill the Name Player Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox3.TextLength == 0)
			{
				MessageBox.Show("Please fill the Name Player Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox4.TextLength == 0)
			{
				MessageBox.Show("Please fill the Name Player Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_player_info|" + textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text + "|\n";
			this.Close();
		}
		void TextBox2KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
		void TextBox4KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
