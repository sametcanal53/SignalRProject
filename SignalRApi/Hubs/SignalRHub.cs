using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;

namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;

        public SignalRHub(
            ICategoryService categoryService,
            IProductService productService,
            IOrderService orderService,
            IMoneyCaseService moneyCaseService,
            IMenuTableService menuTableService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
        }

        public async Task SendStatistics()
        {
            await Clients.All.SendAsync("ReceiveCategoryCount", _categoryService.GetCount());
            await Clients.All.SendAsync("ReceiveActiveCategoryCount", _categoryService.GetCount(true));
            await Clients.All.SendAsync("ReceivePassiveCategoryCount", _categoryService.GetCount(false));
            await Clients.All.SendAsync("ReceiveProductCount", _productService.GetCount());
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameHamburger", _productService.ProductCountByCategoryName("Hamburger"));
            await Clients.All.SendAsync("ReceiveProductCountByCategoryNameDrink", _productService.ProductCountByCategoryName("Drink"));
            await Clients.All.SendAsync("ReceiveProductPriceAvg", _productService.ProductPriceAvg().ToString("0.00") + "₺");
            await Clients.All.SendAsync("ReceiveProductNameByMaxPrice", _productService.ProductNameByMaxPrice());
            await Clients.All.SendAsync("ReceiveProductNameByMinPrice", _productService.ProductNameByMinPrice());
            await Clients.All.SendAsync("ReceiveProductPriceAvgByHamburger", ("~" + _productService.ProductPriceAvg(1).ToString("0.00") + "₺"));
            await Clients.All.SendAsync("ReceiveTotalOrderCount", _orderService.GetCount());
            await Clients.All.SendAsync("ReceiveActiveTotalOrderCount", _orderService.GetCount(true));
            await Clients.All.SendAsync("ReceiveLastOrderPrice", _orderService.LastOrderPrice().ToString("0.00") + "₺");
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", _moneyCaseService.TotalMoneyCaseAmount().ToString("0.00") + "₺");
            await Clients.All.SendAsync("ReceiveTodayTotalMoneyCaseAmount", _moneyCaseService.TotalMoneyCaseAmount(DateTime.Now.Date).ToString("0.00") + "₺");
            await Clients.All.SendAsync("ReceiveMenuTableCount", _menuTableService.GetCount());
        }

        public async Task SendProgress()
        {
            await Clients.All.SendAsync("ReceiveTotalMoneyCaseAmount", _moneyCaseService.TotalMoneyCaseAmount().ToString("0.00") + "₺");
        }
    }
}
