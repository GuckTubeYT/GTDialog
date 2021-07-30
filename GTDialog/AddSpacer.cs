/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 28/07/2021
 * Time: 16:58
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of AddSpacer.
	/// </summary>
	public partial class AddSpacer : Form
	{
		public AddSpacer()
		{
			InitializeComponent();
		}
		void Button3Click(object sender, EventArgs e)
		{
			Variable.resultDialog = "add_spacer|big|\n";
			this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Variable.resultDialog = "add_spacer|small|\n";
			this.Close();
		}
	}
}
