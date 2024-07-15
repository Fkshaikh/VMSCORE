

using System.Drawing;
using QRCoder;

namespace VMS.Utility
{
    public class QrCodeGeneratorUtility
    {
        public static string GenerateQrCode(QRCreationData data)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(data.Name + "\n" + data.PhoneNumber + "\n" + data.FlatOwner.FlatNumber, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            string path = "./images/" + data.Name + ".png";
            qrCodeImage.Save(path);
            return path;
        }
    }
}
