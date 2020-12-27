using System.Threading;
using System.Windows.Forms;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Mutex mutex = null;
			bool createdNew = false;
			try {
				string mutexName = "MyApplicationName";
				mutex = new Mutex(true, mutexName, out createdNew);
				if (!createdNew) {
					MessageBox.Show("多重起動はできません。");
					mutex.Close();
				} else {
					using (MainDialog form = new MainDialog()) {
						form.ShowDialog();
					}
				}
			} finally {
				if (mutex != null && createdNew) {
					mutex.ReleaseMutex();
					mutex.Close();
				}
			}
		}
	}
}
