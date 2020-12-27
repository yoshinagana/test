using System;
using System.IO;

namespace DeleteDir
{
	class Program
	{
		static void Main(string[] args)
		{
			bool isDirectory = args.Length != 0 && Directory.Exists(args[ 0 ]);
			if (isDirectory) {
				Delete(args[ 0 ]);
			}
		}

		private static void Delete(string dir)
		{
			try {
				Directory.Delete(dir, true);
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
			if (Directory.Exists(dir)) {
				string[] files = Directory.GetFiles(dir);
				string[] dirs = Directory.GetDirectories(dir);
				foreach (string file in files) {
					try {
						File.Delete(file);
					} catch (Exception ex) {
						Console.WriteLine(ex.ToString());
					}
				}
				foreach (string child in dirs) {
					Delete(child);
				}
			}
		}
	}
}
