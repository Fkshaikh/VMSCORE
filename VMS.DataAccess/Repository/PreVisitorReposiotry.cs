using VMS.DataAccess.Data;
using VMS.DataAccess.Repository.IRepository;
using VMS.Models;

namespace VMS.DataAccess.Repository;

public class PreVisitorReposiotry(ApplicationDbContext db) : Repository<PreVisitor>(db), IPrevisitor
{
    public void Update(PreVisitor preVisitor)
    {
        throw new NotImplementedException();
    }
}