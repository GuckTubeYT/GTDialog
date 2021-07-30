/*
 * Created by SharpDevelop.
 * User: GuckTube YT
 * Date: 11/07/2021
 * Time: 16:25
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GTDialog
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			File.WriteAllText("dialog.txt", richTextBox1.Text);
		}
		void Button2Click(object sender, EventArgs e)
		{
			Button bform = new Button();
			bform.ShowDialog();
			richTextBox1.AppendText(Variable.resultDialog);
			Variable.resultDialog = "";
		}
		void Button3Click(object sender, EventArgs e)
		{
			TextDialog tform = new TextDialog();
			tform.ShowDialog();
			richTextBox1.AppendText(Variable.resultDialog);
			Variable.resultDialog = "";
		}
		void Button4Click(object sender, EventArgs e)
		{
			OpenFileDialog ofdialog = new OpenFileDialog();
			ofdialog.Title = "GTDialog";
			ofdialog.Filter = "All TXT Files|*.txt";
			if (ofdialog.ShowDialog() == DialogResult.OK) {
				string file = File.ReadAllText(ofdialog.FileName);
				richTextBox1.Text = file;
			}
			else return;
		}
		void Button5Click(object sender, EventArgs e)
		{
			OtherDialog odform = new OtherDialog();
			odform.ShowDialog();
			richTextBox1.AppendText(Variable.resultDialog);
			Variable.resultDialog = "";
		}
		void Button6Click(object sender, EventArgs e)
		{
			EndDialog eddialog = new EndDialog();
			eddialog.ShowDialog();
			richTextBox1.AppendText(Variable.resultDialog);
			Variable.resultDialog = "";
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dresult = MessageBox.Show("Do you want to Save this File?", "GTDialog", MessageBoxButtons.YesNoCancel);
			if (dresult == DialogResult.Yes) File.WriteAllText("dialog.txt", richTextBox1.Text);
			else if (dresult == DialogResult.No) Environment.Exit(0);
			else if (dresult == DialogResult.Cancel) e.Cancel = true;
			else e.Cancel = true;
		}
	}
}
