using System;
using System.Web.Mvc;
using Vitruvian.Shared.Models;
using Vitruvian.UI.Models;

namespace Vitruvian.UI.Controllers
{
	public class MamaTvojaController : BaseController
    {
        // GET: MamaTvoja
        public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public JsonResult GetClient(int clientId)
		{
			//Response class was created just to keep the data structure consistent in the communication between C# controllers and JavaScript
			//To accomplish this, all methods in every controller should return the same class.
			//NOTE: this part "<Client>" is called "Generics" in c#, try not to bother with it for now.
			var response = new Response<Client>();
			try
			{
				if (clientId <= 0) throw new ArgumentException("Provided clientId must be greater than zero.");
				response.Data = BusinessLogic.GetClient(clientId);
			}
			catch (Exception ex)
			{
				response.Success = false;
				response.Message = ex.Message;
			}
			//Abusing .NET's Json method to serialize our object to JSON format.
			return Json(response);
		}
    }
}