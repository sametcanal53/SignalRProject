using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.EntityLayer.Entities;
namespace SignalRApi.Controllers
{
    public class MoneyCasesController : GenericController
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCasesController(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }

        [HttpGet("TotalMoneyCaseAmount")]
        public IActionResult TotalMoneyCaseAmount(DateTime? date) => Ok(_moneyCaseService.TotalMoneyCaseAmount(date));
    }
}
