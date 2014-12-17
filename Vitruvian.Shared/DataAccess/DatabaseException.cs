using System;

namespace Vitruvian.Shared.DataAccess
{
	public class DatabaseException : Exception
	{
		public DatabaseException(string message) : base(message) 
		{
		}
	}
}