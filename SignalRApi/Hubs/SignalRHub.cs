using AutoMapper;
using Microsoft.AspNetCore.SignalR;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables;

namespace SignalRApi.Hubs
{
    public class SignalRHub : Hub
    {
        private readonly IMapper _mapper;
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly IMoneyCaseService _moneyCaseService;
        private readonly IMenuTableService _menuTableService;
        private readonly IBookingService _bookingService;
        private readonly INotificationService _notificationService;

        public SignalRHub(
            IMapper mapper,
            ICategoryService categoryService,
            IProductService productService,
            IOrderService orderService,
            IMoneyCaseService moneyCaseService,
            IMenuTableService menuTableService,
            IBookingService bookingService,
            INotificationService notificationService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _productService = productService;
            _orderService = orderService;
            _moneyCaseService = moneyCaseService;
            _menuTableService = menuTableService;
            _bookingService = bookingService;
            _notificationService = notificationService;
        }
        public static int clientCount = 0;
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
            await Clients.All.SendAsync("ReceiveActiveTotalOrderCount", _orderService.GetCount(true));
            await Clients.All.SendAsync("ReceiveMenuTableCount", _menuTableService.GetCount());
        }

        public async Task GetBookings()
        {
            await Clients.All.SendAsync("ReceiveBookings", _bookingService.GetList());
        }

        public async Task SendNotifications()
        {
            await Clients.All.SendAsync("ReceiveUnreadNotifications", _notificationService.GetNotifications(false));
            await Clients.All.SendAsync("ReceiveUnreadNotificationsCount", _notificationService.GetNotificationsCount(false));
        }

        public async Task GetMenuTableStatus()
        {
            await Clients.All.SendAsync("ReceiveMenuTableStatus", _mapper.Map<List<MenuTableDto>>(_menuTableService.GetList()));
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public override async Task OnConnectedAsync()
        {
            clientCount++;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            clientCount--;
            await Clients.All.SendAsync("ReceiveClientCount", clientCount);
            await base.OnDisconnectedAsync(exception);
        }
    }
}
