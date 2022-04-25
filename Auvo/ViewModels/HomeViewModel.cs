using Auvo.Models;

namespace Auvo.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<PrevisaoClima> listTopHot { get; set; }
        public IEnumerable<PrevisaoClima> listTopCold { get; set; }
        public IEnumerable<Cidade> listCity { get; set; }
        public IEnumerable<PrevisaoClima> PrevisaoClimaWeek { get; set; }

    }
}
