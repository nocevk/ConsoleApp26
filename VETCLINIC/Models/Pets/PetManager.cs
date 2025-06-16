using System;
using System.Collections.Generic;
using System.Linq;

namespace VetClinic.Models.Pets
{
    public class PetManager : IManager<Pet>
    {
        private readonly List<Pet> pets = new List<Pet>();

        public void Create(Pet item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            pets.Add(item);
        }

        public void Update(Pet item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            int index = pets.FindIndex(p => p == item);
            if (index >= 0)
                pets[index] = item;
        }

        public void Delete(Pet item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            var toRemove = pets.FirstOrDefault(p =>
                p.Name == item.Name &&
                p.Breed == item.Breed
            );
            if (toRemove != null)
                pets.Remove(toRemove);
        }

        public IEnumerable<Pet> GetAll()
        {
            return new List<Pet>(pets);
        }

        public Pet Get(Func<Pet, bool> predicate)
        {
            return pets.FirstOrDefault(predicate);
        }

        public IEnumerable<Pet> GetPetsByOwnerName(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentNullException(nameof(firstName));
            if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentNullException(nameof(lastName));
            return pets.Where(p => 
                p.Owner != null &&
                string.Equals(p.Owner.FirstName, firstName, StringComparison.OrdinalIgnoreCase) &&
                string.Equals(p.Owner.LastName, lastName, StringComparison.OrdinalIgnoreCase)
            ).ToList();
        }
    }
}