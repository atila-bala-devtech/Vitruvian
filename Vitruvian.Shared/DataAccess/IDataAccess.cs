using Vitruvian.Shared.DataAccess.DataModels;

namespace Vitruvian.Shared.DataAccess
{
	public interface IDataAccess
	{
		CustomerData GetCustomer(int customerId);
	}
}