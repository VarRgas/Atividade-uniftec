using Microsoft.AspNetCore.Mvc;

namespace ProjectFacul.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Listar() => View();

        public IActionResult Gravar() => View();

        public IActionResult Excluir() => View();

        public IActionResult Procurar() => View();
    }
}
