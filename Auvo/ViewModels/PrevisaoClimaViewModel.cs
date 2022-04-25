using Auvo.Models;

namespace Auvo.ViewModels
{
    public class PrevisaoClimaViewModel
    {
        public IEnumerable<PrevisaoClima> PrevisaoClimaList { get; set; }
        public IEnumerable<PrevisaoClima> PrevisaoClimaListTopHot { get; set; }
        public IEnumerable<PrevisaoClima> PrevisaoClimaListTopCold { get; set; }

        public string CidadeAtual { get; set; }

        public IEnumerable<PrevisaoClima> PrevisaoClimaWeek { get; set; }
    }
}
