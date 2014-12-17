using Vitruvian.Shared.Configuration;

namespace Vitruvian.Shared
{
	public class WebConfig : IConfigurator
	{
		private IDatabaseConfiguration _databaseConfig;

		public IDatabaseConfiguration Database {
			get
			{
				return _databaseConfig ?? (_databaseConfig = new MsSqlConfigurator
				{
					DatabaseName = "",
					DatabasePassword = "",
					DatabaseUsername = "",
					Host = "",
					Port = 1
				});
			}
			set { _databaseConfig = value; }
		}
	}
}