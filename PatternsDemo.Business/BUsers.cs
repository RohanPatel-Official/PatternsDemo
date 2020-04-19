using PatternsDemo.Domain.DBModels;
using PatternsDemo.IBusiness;
using PatternsDemo.IInfrastructure;

namespace PatternsDemo.Business
{
    public class BUsers : IBUsers
    {
        private readonly IUsersRepository _usersRepository;

        public BUsers(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public Users GetUseryById(int id)
        {
            return _usersRepository.GetUseryById(id);
        }
    }
}
