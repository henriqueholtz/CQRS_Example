using CQRS_read_Infrastructure.Persistence.Peoples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_read_Infrastructure.Persistence
{
    public class Context : IContext
    {
        public IPersonRepository Person { get; set; }
        public Context(IPersonRepository personRepository)
        {
            Person = personRepository;
        }

    }
}
