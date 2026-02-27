using WebApplication1.Models;
using System.Linq;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {

        private Table_1 db = new Table_1();

        public ActionResult Index()
        {

            var userList = db.Table_1.ToList();


            return View(userList); 


        }
    }
}