using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
namespace SignalRApi.Controllers
{
    public class MoneyCaseController : GenericController
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCaseController(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }

        [HttpGet("TotalMoneyCaseAmount")]
        public IActionResult TotalMoneyCaseAmount(DateTime? date) => Ok(_moneyCaseService.TotalMoneyCaseAmount(date));
    }
}
