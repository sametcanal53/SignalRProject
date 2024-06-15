using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.ControllerRequest;
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
        public IActionResult TotalMoneyCaseAmount(TotalMoneyCaseAmountRequest request) => Ok(_moneyCaseService.TotalMoneyCaseAmount(request.Date));
    }
}
