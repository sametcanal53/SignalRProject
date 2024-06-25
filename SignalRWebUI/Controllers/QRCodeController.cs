using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using QRCoder;
using System.Drawing.Imaging;
using static QRCoder.QRCodeGenerator;

namespace SignalRWebUI.Controllers
{
    public class QRCodeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return View();
            using var stream = new MemoryStream();
            new QRCodeGenerator().CreateQrCode(value, ECCLevel.Q).GetGraphic(5).Save(stream, ImageFormat.Png);
            ViewBag.QrCodeImage = "data:image/png;base64," + Convert.ToBase64String(stream.ToArray());
            return View();
        }
    }
}
