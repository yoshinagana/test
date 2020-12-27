using System.ServiceProcess;

namespace WindowsService2
{
	public partial class TestService : ServiceBase
	{
		public TestService()
		{
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
		}

		protected override void OnStop()
		{
		}
	}
}
