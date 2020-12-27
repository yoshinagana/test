using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
	public partial class MainDialog : Form
	{
		private const string ok = "OK";
		private const string execute = "Execute";
		private const string abort = "Abort";
		private bool isAbort;
		private List<int> list;

		public MainDialog()
		{
			this.InitializeComponent();
			this.isAbort = true;
			this.list = new List<int>();
		}

		private void Form1Load(object sender, EventArgs e)
		{
			string index = "Index";
			string resutlt = "Result";
			this.dataGridViewTargets.Columns.Add(index, index);
			this.dataGridViewTargets.Columns.Add(resutlt, resutlt);
			for (int i = 0; i < 5; i++) {
				this.list.Add(i + 1);
				this.dataGridViewTargets.Rows.Add(i + 1, null);
			}
		}

		private void ButtonExecuteClick(object sender, EventArgs e)
		{
			if (this.buttonExecute.Text.Equals(execute)) {
				new AbortDialog().Show(this);
				this.ChangeButtonState(false);
				this.buttonExecute.Text = abort;
				this.UpdateList();
				this.ChangeButtonState(true);
				this.buttonExecute.Text = execute;
			} else {
				this.ChangeButtonState(true);
				this.buttonExecute.Text = execute;
			}
		}

		private void Login()
		{
			this.OutputLog("Login");
			Thread.Sleep(1000);
			Application.DoEvents();
		}

		private void UpdateList()
		{
			try {
				this.Login();
				int num = this.list.Count;
				for (int i = 0; i < num; i++) {
					if (this.isAbort) {
						break;
					}
					DataGridViewCell cell = this.dataGridViewTargets.Rows[ i ].Cells[ 1 ];
					object value = cell.Value;
					if (!ok.Equals(value)) {
						cell.Value = ok;
						string text = string.Format("{0},{1}{2}", i + 1, ok, Environment.NewLine);
						this.textBoxLog.AppendText(text);
						Thread.Sleep(500);
					}
					Application.DoEvents();
				}
				if (this.isAbort) {
					MessageBox.Show("Aborted");
				} else {
					MessageBox.Show("Complete");
				}
			} catch (Exception ex) {
				Console.WriteLine(ex);
			}
		}

		private void ButtonCloseClick(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ButtonClearClick(object sender, EventArgs e)
		{
			int num = this.list.Count;
			for (int i = 0; i < num; i++) {
				DataGridViewCell cell = this.dataGridViewTargets.Rows[ i ].Cells[ 1 ];
				cell.Value = null;
			}
		}

		private void ChangeButtonState(bool enable)
		{
			this.buttonClear.Enabled = enable;
			this.buttonClose.Enabled = enable;
			this.isAbort = enable;
		}

		private void OutputLog(string format, params object[] args)
		{
			string text = string.Format("{0}{1}", string.Format(format, args), Environment.NewLine);
			this.textBoxLog.AppendText(text);
			Application.DoEvents();
		}
	}
}
