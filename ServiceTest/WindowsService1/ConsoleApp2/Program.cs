using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using ConsoleApp2.Properties;

namespace ConsoleApp2
{
	class Program
	{
		private static string moduleName;
		private static string log;

		static void Main(string[] args)
		{
			string modulePath = Assembly.GetExecutingAssembly().Location;
			moduleName = Path.GetFileNameWithoutExtension(modulePath);
			Settings settings = Settings.Default;
			string dir = settings.BaseDir;
			string dir1 = Path.Combine(dir, settings.InputDir);
			string dir2 = Path.Combine(dir, settings.OutputDir);
			log = Path.Combine(dir, settings.Log);
			LogMethodIn();
			Directory.CreateDirectory(dir1);
			Directory.CreateDirectory(dir2);
			int count = 1;
			while (count != 10) {
				string[] files = Directory.GetFiles(dir1);
				foreach (string src in files) {
					MoveFile(src, dir2, ref count);
					if (count == 10) {
						break;
					}
				}
				Console.Write(".");
				Thread.Sleep(1000);
			}
			LogMethodOut();
		}

		private static void MoveFile(string src, string dir2, ref int count)
		{
			LogMethodIn();

			string name = Path.GetFileName(src);
			string dst = Path.Combine(dir2, name);
			if (File.Exists(dst)) {
				string bak = string.Format("{0}.bak", dst);
				File.Copy(dst, bak, true);
				File.Delete(dst);
			}
			File.Move(src, dst);
			Log("[{0}] {1}", count, dst);
			count++;

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
