using Microsoft.AspNetCore.Mvc;
using VMS.DataAccess.Repository.IRepository;
using VMS.Utility;

namespace VMS.Areas.FlatOwner.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PreVisitor(IUnitOfWork db) : Controller
{
    // Register the PreVisitor via the FlatOwner
    [HttpPost("Register")]
    public IActionResult RegisterPrevistor([FromBody] RegisterPrevisitorDto body)
    {
     
        Models.FlatOwner? flatOwner;
        //Fetch the FlatOwner from the database
        if (int.TryParse(body.FlatOwnerID, out int flatOwnerId))
        {
            flatOwner = db.FlatOwner.GetAll().FirstOrDefault(x => x.Id == flatOwnerId);
        }
        else
        {
            // Handle the case where FlatOwnerID is not a valid integer
            return BadRequest("Invalid FlatOwnerID");
        }
        
        //Register the PreVisitor
        if (flatOwner == null) return NotFound("FlatOwner Not Found");

        var qrCreationData = new QRCreationData()
        {
            Name = body.Name,
            PhoneNumber = body.PhoneNumber,
            FlatOwner = flatOwner

        };
        // create unique qr url
        var uniqueQr = QrCodeGeneratorUtility.GenerateQrCode(qrCreationData);
        var preVisitor = new Models.PreVisitor()
        {
            Name = body.Name,
            PhoneNumber = body.PhoneNumber,
            FlatOwner = flatOwner,
            UniqueQR = uniqueQr
        };
        db.PreVisitor.Add(preVisitor);
        db.Save();
        
        return Ok("PreVisitor Registered Successfully");

    }
}
