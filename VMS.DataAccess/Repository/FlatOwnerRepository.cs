using VMS.DataAccess.Data;
using VMS.DataAccess.Repository.IRepository;
using VMS.Models;

namespace VMS.DataAccess.Repository;

public class FlatOwnerRepository(ApplicationDbContext db): Repository<FlatOwner>(db), IFlatOwner
{
    public void Update(FlatOwnerRepository flatOwnerRepository)
    {
        throw new NotImplementedException();
    }
}