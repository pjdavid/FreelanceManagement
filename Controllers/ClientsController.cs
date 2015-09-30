using FreelanceManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace FreelanceManagement.Controllers
{
    public class ClientsController : Controller
    {
        ClientService _service = new ClientService();

        // GET: Clients
        public ActionResult Index()
        {
            //Just for test, must get user id from session
            const int currentUserId = 1;

            var data = _service.GetListOfClient(currentUserId);

            return View(data);
        }

        public ActionResult Details(Guid clientId)
        {
            var data = _service.GetClientByData(clientId);

            return View(data);
        }
    }
}