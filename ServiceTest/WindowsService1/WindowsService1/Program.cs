using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.ServiceProcess;
using WindowsService1.Properties;

namespace WindowsService1
{
	static class Program
	{
		private static string moduleName;
		private static string log;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			string modulePath = Assembly.GetExecutingAssembly().Location;
			moduleName = Path.GetFileNameWithoutExtension(modulePath);
			Settings settings = Settings.Default;
			string dir = settings.BaseDir;
			log = Path.Combine(dir, settings.Log);
			LogMethodIn();
			try {
				ServiceBase[] ServicesToRun = { new TestService() };
				ServiceBase.Run(ServicesToRun);
			} catch (Exception ex) {
				Log("Server Error {0}", ex.ToString());
			}
			LogMethodOut();
		}

		public static void Log(string format, params object[] args)
		{
			string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
			string message = string.Format(format, args);
			File.AppendAllText(log, string.Format("{0} [{1}] {2}{3}", now, moduleName, message, Environment.NewLine));
		}

		public static void LogMethodIn()
		{
			StackFrame stackFrame = new StackFrame(1);
			string name = stackFrame.GetMethod().Name;
			Log("{0}() in", name);
		}

		public static void LogMethodOut()
		{
			StackFrame stackFrame = new StackFrame(1);
			string name = stackFrame.GetMethod().Name;
			Log("{0}() out", name);
		}
	}
}
