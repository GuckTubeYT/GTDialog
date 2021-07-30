/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 16:19
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of PlayerPickerButton.
	/// </summary>
	public partial class PlayerPickerButton : Form
	{
		public PlayerPickerButton()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0) {
				MessageBox.Show("Please fill the Player Picker Name Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (textBox2.TextLength == 0) {
				MessageBox.Show("Please fill the Button Name Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_player_picker|" + textBox1.Text + "|" + textBox2.Text + "|\n";
			this.Close();
		}
	}
}
