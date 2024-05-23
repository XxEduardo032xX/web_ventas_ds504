using Microsoft.AspNetCore.Mvc;
using web_ventas_ds504.Data;
using web_ventas_ds504.Models;

namespace web_ventas_ds504.Controllers
{
    public class AutorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AutorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Autor> ListarAutor = _context.Autor;
            return View(ListarAutor);
        }
    }
}
