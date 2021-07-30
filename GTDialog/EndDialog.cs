/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 20:08
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of EndDialog.
	/// </summary>
	public partial class EndDialog : Form
	{
		public EndDialog()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0) {
				MessageBox.Show("Please fill the Dialog Name Textbox", "GTDialog", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			Variable.resultDialog = "end_dialog|" + textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|\n";
			this.Close();
		}
	}
}
