/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 21/07/2021
 * Time: 11:00
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of OtherDialog.
	/// </summary>
	public partial class OtherDialog : Form
	{
		public OtherDialog()
		{
			InitializeComponent();
		}
		void Button2Click(object sender, EventArgs e)
		{
			PlayerInfo pidialog = new PlayerInfo();
			pidialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Variable.resultDialog = "add_quick_exit\n";
			this.Close();
		}
	}
}