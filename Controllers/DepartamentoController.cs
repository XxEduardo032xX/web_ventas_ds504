using Microsoft.AspNetCore.Mvc;
using web_ventas_ds504.Data;
using web_ventas_ds504.Models;

namespace web_ventas_ds504.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartamentoController(ApplicationDbContext context) 
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Departamento> ListarDepartamento = _context.Departamento;
            return View(ListarDepartamento);
        }
    }
}
