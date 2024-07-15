using VMS.Models;

namespace VMS.DataAccess.Repository.IRepository;

public interface IPrevisitor: IRepository<PreVisitor>
{
    void Update(PreVisitor preVisitor);
}