using HueFestivalTicket.Database;
using HueFestivalTicket.Models.ProgramFes;
using HueFestivalTicket.Models.qrCode;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.IO;
using QRCoder;

namespace HueFestivalTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrcodeController : ControllerBase
    {
        private readonly DataContext _context;
        public QrcodeController(DataContext context)
        {
            _context = context;


        }

        //[HttpPost]
        ////[HttpPost, Authorize(Roles = "Admin")]
        //public string ReadQRCode(string imagePath)
        //{
        //    using (var bitmap = new Bitmap(imagePath))
        //    {
        //        var qrCodeBitmap = new QRCodeBitmap(bitmap);
        //        var qrCodeDecoder = new QRCodeDecoder();
        //        var qrCodeText = qrCodeDecoder.Decode(qrCodeBitmap);

        //        return qrCodeText;
        //    }
        //}


    }
}
