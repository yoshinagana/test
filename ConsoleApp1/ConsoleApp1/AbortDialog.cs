using System.Windows.Forms;

namespace ConsoleApp1
{
	public partial class AbortDialog : Form
	{
		public AbortDialog()
		{
			InitializeComponent();
		}

		private void AbortDialog_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.Dispose();
		}

		private void buttonAbort_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
