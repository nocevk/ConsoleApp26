using System;
using System.Collections.Generic;
using System.Linq;

namespace VetClinic.Models.People
{
    public class PersonManager : IManager<Person>
    {
        private readonly List<Person> people = new List<Person>();

        public void Create(Person item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            people.Add(item);
        }

        public void Update(Person item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            int index = people.FindIndex(p => p == item);
            if (index >= 0)
                people[index] = item;
        }

        public void Delete(Person item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            var toRemove = people.FirstOrDefault(p =>
                p.FirstName == item.FirstName &&
                p.LastName == item.LastName
            );
            if (toRemove != null)
                people.Remove(toRemove);
        }

        public IEnumerable<Person> GetAll()
        {
            return new List<Person>(people);
        }

        public Person Get(Func<Person, bool> predicate)
        {
            return people.FirstOrDefault(predicate);
        }
    }
}