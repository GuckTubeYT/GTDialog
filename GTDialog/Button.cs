/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 11/07/2021
 * Time: 17:18
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GTDialog
{
	/// <summary>
	/// Description of Button.
	/// </summary>
	public partial class Button : Form
	{
		public Button()
		{
			InitializeComponent();
			Variable.resultDialog = "";
		}
		void Button1Click(object sender, EventArgs e)
		{
			NormalButton nbdialog = new NormalButton();
			nbdialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			AchieveButton abdialog = new AchieveButton();
			abdialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			CheckboxButton cbutton = new CheckboxButton();
			cbutton.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button4Click(object sender, EventArgs e)
		{
			ButtonImage bibutton = new ButtonImage();
			bibutton.ShowDialog();
			if (Variable.resultDialog.Length == 0) return; 
			else this.Close();
		}
		void Button5Click(object sender, EventArgs e)
		{
			ItemPickerButton ipbutton = new ItemPickerButton();
			ipbutton.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button6Click(object sender, EventArgs e)
		{
			PlayerPickerButton pibutton = new PlayerPickerButton();
			pibutton.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button7Click(object sender, EventArgs e)
		{
			UrlButton ubdialog = new UrlButton();
			ubdialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
		void Button8Click(object sender, EventArgs e)
		{
			RedirectWorldButton rwbdialog = new RedirectWorldButton();
			rwbdialog.ShowDialog();
			if (Variable.resultDialog.Length == 0) return;
			else this.Close();
		}
	}
}
