using EstudioCapra.Backend;
using Microsoft.AspNetCore.Mvc;

namespace EstudioCapra.WebApp.Controllers
{
    public class BaseController : Controller
    {
        public IUnitOfWork _UnitOfWork { get; set; }

    }
}


