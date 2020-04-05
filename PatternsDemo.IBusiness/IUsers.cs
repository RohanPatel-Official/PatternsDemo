using PatternsDemo.Domain.DBModels;
using System;

namespace PatternsDemo.IBusiness
{
    public interface IUsers
    {
        Users GetUseryById(Guid id);
    }
}
