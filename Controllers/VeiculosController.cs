using Microsoft.AspNetCore.Mvc;
using Transportei.Web.Models;

namespace Transportei.Web.Controllers
{
    public class VeiculosController : Controller
    {
        public IActionResult Index()
        {
            var lista = new List<Veiculo>
            {
                new Veiculo { Id = 1, Placa = "ABC1234", Cor = "Vermelho", Modelo = "Fiat Uno", Ano = "2010" }
            };
            
            return View(lista);
        }
    }
}
