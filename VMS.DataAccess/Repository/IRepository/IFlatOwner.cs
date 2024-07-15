using VMS.Models;

namespace VMS.DataAccess.Repository.IRepository;

public interface IFlatOwner :IRepository<FlatOwner>
{
    void Update(FlatOwnerRepository flatOwnerRepository);
    
}