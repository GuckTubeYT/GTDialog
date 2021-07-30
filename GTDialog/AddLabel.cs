/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 19/07/2021
 * Time: 19:33
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of AddLabel.
	/// </summary>
	public partial class AddLabel : Form
	{
		public AddLabel()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("Please fill Label text Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "add_label|" + textBox1.Text + "|\n";
			this.Close();
		}
	}
}
