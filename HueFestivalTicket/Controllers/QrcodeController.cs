using HueFestivalTicket.Database;
using HueFestivalTicket.Models.ProgramFes;
using HueFestivalTicket.Models.qrCode;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.IO;
using QRCoder;
using ZXing;
using ZXing.SkiaSharp;
using SkiaSharp;
using ZXing.Common;
using System;
using ZXing.QrCode.Internal;
using System.Runtime.InteropServices;

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

        [HttpPost("scanQrcode")]

        //[HttpPost, Authorize(Roles = "Admin")]
        public async Task<IActionResult> ScanQRCode()
        {
            string image = "D:\\Dotnet\\HueFestivalTicket\\HueFestivalTicket\\Image\\qrcode.png";
            //string image = "D:\\Dotnet\\HueFestivalTicket\\HueFestivalTicket\\Image\\qrcodeIsvalid.png";
            var reader = new BarcodeReaderGeneric();
            Bitmap bitmap = (Bitmap)Image.FromFile(image);
            using (bitmap)
            {
                LuminanceSource source;
                source = new ZXing.Windows.Compatibility.BitmapLuminanceSource(bitmap);
                Result result = reader.Decode(source);
                if (result != null)
                {

                    string qrCodeText = result.Text;

                    bool isQRCodeValid = await CheckQRCodeValidity(qrCodeText);

                    if (isQRCodeValid)
                    {
                        return Ok("QR Code is valid.");
                    }
                    else
                    {
                        return BadRequest("QR Code is invalid.");
                    }

                    return Ok(result.Text);
                }
                else
                {
                    return NotFound("No QR Code found in the image.");
                }
            }
        }

        private async Task<bool> CheckQRCodeValidity(string qrCodeText)
        {
                var existingRecord = await _context.Qrcode.FirstOrDefaultAsync(record => record.qrcode == qrCodeText);
                if (existingRecord != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
        }
    }
}

