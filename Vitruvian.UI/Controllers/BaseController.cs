using System.Web.Mvc;
using Vitruvian.BLL;
using Vitruvian.Shared.BusinessLogic;

namespace Vitruvian.UI.Controllers
{
	/// <summary>
	/// Used to define common functionality and dependencies for all contollers (so we don't have to copy/paste code throughout controllers)
	/// </summary>
	public class BaseController : Controller
	{
		/// <summary>
		/// Declared as IBusinessLogic interface instead of concrete BusinessLogic class so we avoid strong dependency to concrete implementation.
		/// </summary>
		protected readonly IBusinessLogic BusinessLogic;

		public BaseController()
		{
			//"new" keyword inside a class isn't a good practice, but we'll keep doing it for the time being just to keep it simple.
			//the correct way to define dependency would be to "inject" it through the constructor
			BusinessLogic = new BusinessLogic();
		}
	}
}