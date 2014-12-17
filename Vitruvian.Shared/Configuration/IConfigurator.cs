namespace Vitruvian.Shared.Configuration
{
	public interface IConfigurator
	{
		IDatabaseConfiguration Database { get; set; }
	}
}