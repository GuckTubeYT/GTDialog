/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 11/07/2021
 * Time: 17:27
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of TextDialog.
	/// </summary>
	public partial class TextDialog : Form
	{
		public TextDialog()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			AddLabel alform = new AddLabel();
			alform.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			AddLabelWithIcon alwiform = new AddLabelWithIcon();
			alwiform.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			SmallText stdialog = new SmallText();
			stdialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			AddSpacer asdialog = new AddSpacer();
			asdialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button5Click(object sender, EventArgs e)
		{
			TextInput tidialog = new TextInput();
			tidialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button6Click(object sender, EventArgs e)
		{
			TextInputPassword tipdialog = new TextInputPassword();
			tipdialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button7Click(object sender, EventArgs e)
		{
			AddTextbox atdilog = new AddTextbox();
			atdilog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
	}
}
