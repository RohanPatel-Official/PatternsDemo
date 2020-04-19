using Microsoft.EntityFrameworkCore;
using PatternsDemo.Domain.DBModels;
using PatternsDemo.IInfrastructure;
using System.Linq;

namespace PatternsDemo.Infrastructure
{
    public class UsersRepository : BaseRepository<Users>, IUsersRepository
    {
        private readonly PatternDemoDBContext _context;

        public UsersRepository(PatternDemoDBContext context) : base(context)
        {
            this._context = context;
        }

        public Users GetUseryById(int id)
        {
            return _context.Users.AsNoTracking().Where(x => x.UserID == id).FirstOrDefault();
        }
    }
}
