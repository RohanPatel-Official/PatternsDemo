using PatternsDemo.Domain.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsDemo.IInfrastructure
{
    public interface IUsers
    {
        Users GetUseryById(Guid id);
    }
}
