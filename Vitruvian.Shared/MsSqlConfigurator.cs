using Vitruvian.Shared.Configuration;

namespace Vitruvian.Shared
{
	public class MsSqlConfigurator : IDatabaseConfiguration
	{
		public string Host { get; set; }
		public string DatabasePassword { get; set; }
		public string DatabaseUsername { get; set; }
		public string DatabaseName { get; set; }
		public int Port { get; set; }
	}
}