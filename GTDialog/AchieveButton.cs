/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 18:14
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of AchieveButton.
	/// </summary>
	public partial class AchieveButton : Form
	{
		public AchieveButton()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox3.TextLength == 0)
			{
				MessageBox.Show("Please fill the Achievement Icon ID", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}
			Variable.resultDialog = "add_achieve|" + textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|\n";
			this.Close();
		}
		void TextBox3KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}
	}
}
