using System.IO;
using System.Diagnostics;
using System.ServiceProcess;
using System.Timers;
using WindowsService1.Properties;

namespace WindowsService1
{
	public partial class TestService : ServiceBase
	{
		private readonly Timer timer;

		private bool stoped;

		public TestService()
		{
			InitializeComponent();
			this.timer = new Timer(10000);
			this.timer.Elapsed += new ElapsedEventHandler(this.TimerElapsed);
		}

		protected override void OnStart(string[] args)
		{
			Program.LogMethodIn();
			this.timer.Enabled = true;
			this.stoped = false;
			this.Execute();
			Program.LogMethodOut();
		}

		private void Execute()
		{
			Program.LogMethodIn();
			Settings settings = Settings.Default;
			string exe = Path.Combine(settings.AppDir, string.Format("{0}.exe", settings.AppName));
			if (File.Exists(exe)) {
				Program.Log("Start {0}", settings.AppName);
				using (Process proc = new Process()) {
					ProcessStartInfo si = proc.StartInfo;
					si.UseShellExecute = false;
					si.FileName = exe;
					proc.Start();
				}
			} else {
				Program.Log("File not found.[{0}]", exe);
				this.Stop();
			}
			Program.LogMethodOut();
		}

		protected override void OnStop()
		{
			Program.LogMethodIn();
			this.stoped = true;
			this.timer.Enabled = false;
			string appName = Settings.Default.AppName;
			Process[] processList = Process.GetProcesses();
			bool executed = false;
			foreach (Process p in processList) {
				executed = p.ProcessName == appName;
				if (executed) {
					p.Kill();
					Program.Log("{0} was killed.", appName);
					break;
				}
			}
			if (!executed) {
				Program.Log("{0} is not running.", appName);
			}
			Program.LogMethodOut();
		}

		private void TimerElapsed(object sender, ElapsedEventArgs e)
		{
			Program.LogMethodIn();
			if (!this.stoped) {
				string appName = Settings.Default.AppName;
				bool executed = false;
				Process[] processList = Process.GetProcesses();
				foreach (Process p in processList) {
					executed = p.ProcessName == appName;
					if (executed) {
						Program.Log("{0} is already executed.", appName);
						break;
					}
				}
				if (!executed) {
					this.Execute();
				}
			} else {
				Program.Log("Stoped");
			}
			Program.LogMethodOut();
		}
	}
}
