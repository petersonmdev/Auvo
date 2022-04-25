using Auvo.Repositories.Interfaces;
using Auvo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Auvo.Controllers
{
    public class PrevisaoClimaController : Controller
    {
        private readonly IPrevisaoClimaRepository _previsaoTempoRepository;

        public PrevisaoClimaController(IPrevisaoClimaRepository previsaoTempoRepository)
        {
            _previsaoTempoRepository = previsaoTempoRepository;
        }

        public IActionResult List()
        {

            var previsaoClima = new PrevisaoClimaViewModel();
            previsaoClima.PrevisaoClimaWeek = _previsaoTempoRepository.ListPrevisaoClima;

            return View(previsaoClima);
        }
    }
}
