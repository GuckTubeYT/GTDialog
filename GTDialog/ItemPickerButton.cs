/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 14:15
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of ItemPickerButton.
	/// </summary>
	public partial class ItemPickerButton : Form
	{
		public ItemPickerButton()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Variable.resultDialog = "add_item_picker|" + textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|\n";
			this.Close();
		}
	}
}
