namespace Vitruvian.Shared.Configuration
{
	public interface IDatabaseConfiguration
	{
		string Host { get; set; }
		string DatabasePassword { get; set; }
		string DatabaseUsername { get; set; }
		string DatabaseName { get; set; }
		int Port { get; set; }
	}
}