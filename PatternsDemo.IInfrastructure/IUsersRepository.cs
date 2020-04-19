using PatternsDemo.Domain.DBModels;

namespace PatternsDemo.IInfrastructure
{
    public interface IUsersRepository : IBaseRepository<Users>
    {
        Users GetUseryById(int id);
    }
}
