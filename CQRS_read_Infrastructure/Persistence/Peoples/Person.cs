using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_read_Infrastructure.Persistence.Peoples
{
    [Flags]
    public enum PersonClass
    {
        Adminstrator,
        Common
    }


    public class Person
    {
        public int Id { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PersonClass Type{ get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int id, PersonClass personClass, string name, int age)
        {
            if (String.IsNullOrWhiteSpace(name)) 
                throw new ArgumentException("Name is requerid");

            Id = id;
            Type = personClass;
            Name = name;
            Age = age;
        }

        public Person(PersonClass personClass, string name, int age)
        {
            Type = personClass;
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{ this.Type}:[Class]{this.Type}, [Name]: {this.Name}, [Age]: {this.Age}";
        }
    }
}
