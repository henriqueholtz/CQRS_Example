using CQRS_read_Infrastructure.Persistence.Peoples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_read_Application.Peoples
{
    public class Person : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public Person(IPersonRepository repo)
        {
            _personRepository = repo;
        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

        public Person Find(int id)
        {
            return _personRepository.Find(id);
        }

        public IQueryable<Person> GetAll()
        {
            return _personRepository.Get();
        }

        public IQueryable<Person> GetByName(string name)
        {
            return _personRepository.Get(p => p.Name.ToLower().Contains(name.ToLower()));
        }

        public void Insert(Person person)
        {
            _personRepository.Insert(person);
        }

        public void Update(Person person)
        {
            _personRepository.Update(person);
        }
    }
}
