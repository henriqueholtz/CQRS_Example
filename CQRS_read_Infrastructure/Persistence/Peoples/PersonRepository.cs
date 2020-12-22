using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_read_Infrastructure.Persistence.Peoples
{
    public class PersonRepository : IPersonRepository
    {
        private static List<Person> listPersonMemory = new List<Person>();
        public void Delete(Person entity)
        {
            listPersonMemory.Remove(entity);
        }

        public void Delete(object id)
        {
            listPersonMemory.Remove(this.Find(id));
        }

        public Person Find(object id)
        {
            return listPersonMemory.AsQueryable().FirstOrDefault(predicate => predicate.Id.Equals(id));
        }

        public IQueryable<Person> Get(Expression<Func<Person, bool>> predicate = null)
        {
            return predicate != null 
                ? listPersonMemory.AsQueryable().Where(predicate)
                : listPersonMemory.AsQueryable();
        }

        public void Insert(Person entity)
        {
            if (entity.Id <= 0)
            {
                entity = new Person(listPersonMemory.Count + 1, entity.Type, entity.Name, entity.Age);
                listPersonMemory.Add(entity);
            }
        }

        public void Update(Person entity)
        {
            var person = this.Find(entity.Id);
            person.Type = entity.Type;
            person.Name = entity.Name;
            person.Age = entity.Age;
        }
    }
}
