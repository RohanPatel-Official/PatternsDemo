using PatternsDemo.Domain.DBModels;

namespace PatternsDemo.IBusiness
{
    public interface IBUsers
    {
        Users GetUseryById(int id);
    }
}
