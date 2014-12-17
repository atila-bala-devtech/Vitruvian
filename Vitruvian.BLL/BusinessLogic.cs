using System;
using Vitruvian.DataAccess;
using Vitruvian.Shared.BusinessLogic;
using Vitruvian.Shared.DataAccess;
using Vitruvian.Shared.DataAccess.DataModels;
using Vitruvian.Shared.Models;

namespace Vitruvian.BLL
{
	public class BusinessLogic : IBusinessLogic
	{
		private readonly IDataAccess _dataAccess;

		public BusinessLogic()
		{
			//"new" keyword inside a class isn't a good practice, but we'll keep doing it for the time being just to keep it simple.
			//the correct way to define dependency would be to "inject" it through the constructor
			_dataAccess = new MsSqlDataAccess();
		}

		public Client GetClient(int clientId)
		{
			Client client;
			try
			{
				var customerData = _dataAccess.GetCustomer(clientId);
				//data access returns different type of data so we need to convert it to the correct one and we use private method for this.
				client = GetClientFromCustomerData(customerData);
			}
			catch (DatabaseException ex)
			{
				//we want to catch only DatabaseException, so we process it accordingly and throw the new one to caller.
				//you'll want to do this if you want to hide sensitive data like username/password/db location or if you want to do any kind of logging or whatever.
				throw new Exception(string.Format("Couldn't retrieve data for client #{0} from storage.", clientId), ex);
			}
			return client;
		}

		private static Client GetClientFromCustomerData(CustomerData customerData)
		{
			return new Client
			{
				Address = customerData.Address1,
				Country = customerData.Country,
				FirstName = customerData.FirstName,
				LastName = customerData.LastName,
				Status = customerData.IsActive ? ClientStatus.Active : ClientStatus.Terminated
			};
		}
	}
}