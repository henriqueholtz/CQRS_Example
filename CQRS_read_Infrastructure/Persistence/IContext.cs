using CQRS_read_Infrastructure.Persistence.Peoples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_read_Infrastructure.Persistence
{
    public interface IContext
    {
        IPersonRepository Person { get; set; }
    }
}
