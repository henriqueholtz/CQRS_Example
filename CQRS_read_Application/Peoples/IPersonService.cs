﻿using CQRS_read_Infrastructure.Persistence.Peoples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_read_Application.Peoples
{
    public interface IPersonService : IApplicationService<Person>
    {
        Person Find(int id);
        IQueryable<Person> GetByName(string name);
        IQueryable<Person> GetAll();
        void Insert(Person person);
        void Update(Person person);
        void Delete(int id);
    }
}
