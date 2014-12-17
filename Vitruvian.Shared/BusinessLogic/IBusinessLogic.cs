using Vitruvian.Shared.Models;

namespace Vitruvian.Shared.BusinessLogic
{
	public interface IBusinessLogic
	{
		Client GetClient(int clientId);
	}
}