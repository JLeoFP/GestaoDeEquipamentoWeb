using Microsoft.AspNetCore.Mvc;

namespace GestaoDeEquipamentosWeb.ConsoleApp.Controllers;
// MVC model view controller.
public class HomeController : Controller
{
    public ActionResult Index() //pagina inicial de un controlador
    {
        return View();
    }
}