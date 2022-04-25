using Auvo.Models;
using Auvo.Repositories.Interfaces;
using Auvo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Auvo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPrevisaoClimaRepository _previsaoClimaRepository;
        private readonly ICidadeRepository _cidadeRepository;

        public HomeController(
            IPrevisaoClimaRepository previsaoClimaRepository,
            ICidadeRepository cidadeRepository)
        {
            _previsaoClimaRepository = previsaoClimaRepository;
            _cidadeRepository = cidadeRepository;
        }

        public IActionResult Index(int id)
        {
            var homeViewModel = new HomeViewModel {
                listTopHot = _previsaoClimaRepository.ListPrevisaoClimaTopQuente,
                listTopCold = _previsaoClimaRepository.ListPrevisaoClimaTopFrio,
                listCity = _cidadeRepository.ListCidade,
                PrevisaoClimaWeek = _previsaoClimaRepository.ListPrevisaoClimaByCidadeId(id)
            };
            return View(homeViewModel);
        }

        public IActionResult GetPrevisao(int id)
        {

            var previsaoClima = new PrevisaoClimaViewModel();
            previsaoClima.PrevisaoClimaWeek = _previsaoClimaRepository.ListPrevisaoClimaByCidadeId(id);

            return View(previsaoClima);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}